using System.Threading.Tasks;
using System;
using System.Linq;
using Chadwick.Database;
using Chadwick.Database.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Octokit;

namespace Chadwick.Processor.Functions
{
    public class CommitProcessor
    {
        private readonly ChadwickDbContext _dbContext;
        private readonly GitHubClient _gitHubClient;
        
        public CommitProcessor(ChadwickDbContext dbContext, GitHubClient gitHubClient)
        {
            _dbContext = dbContext;
            _gitHubClient = gitHubClient;
        }

        [FunctionName("CommitProcessor")]
        public async Task RunAsync(
            [QueueTrigger("commitsqueue", Connection = "AzureWebJobsStorage")] string commitId,
            [Queue("csvqueue"), StorageAccount("AzureWebJobsStorage")] ICollector<string> csvQueue,
            ILogger log)
        {
            // Get the CommitJob to process
            var commitJob = await _dbContext.CommitProcessorJobs.FirstOrDefaultAsync(c => c.Id == Convert.ToInt32(commitId));
            if (commitJob == null) new Exception("Not found");
            
            // Update Job Status
            commitJob.Status = ProcessorStatuses.Processing;
            _dbContext.CommitProcessorJobs.Update(commitJob);
            await _dbContext.SaveChangesAsync();

            // Get the commit has and determine what files need to be processed
            var repo = await _gitHubClient.Repository.Get("chadwickbureau", "baseballdatabank");
            var contents = await _gitHubClient.Repository.Content.GetAllContents(repo.Id, "core");
            contents = contents.Where(f => f.DownloadUrl.EndsWith("csv")).ToList();
            
            // Update the Commit Job in the Database
            commitJob.FilesToProcessCount = contents.Count;
            _dbContext.CommitProcessorJobs.Update(commitJob);
            await _dbContext.SaveChangesAsync();
            
            // Queue CSV Processor Jobs
            foreach (var file in contents)
            {
                var csvJob = new CsvProcessorJob
                {
                    CommitJob = commitJob,
                    FileName = file.Name,
                    DownloadUrl = file.DownloadUrl,
                    Status = ProcessorStatuses.Pending
                };
                await _dbContext.CsvProcessorJobs.AddAsync(csvJob);
                await _dbContext.SaveChangesAsync();
                csvQueue.Add(csvJob.Id.ToString());
            }
        }
    }
}