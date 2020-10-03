using System.Threading.Tasks;
using Chadwick.Database;
using Chadwick.Database.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Octokit;

namespace Chadwick.Processor.Functions
{
    public class RepoProcessor
    {
        private readonly ChadwickDbContext _dbContext;
        private readonly GitHubClient _gitHubClient;
        
        public RepoProcessor(ChadwickDbContext dbContext, GitHubClient gitHubClient)
        {
            _dbContext = dbContext;
            _gitHubClient = gitHubClient;
        }
        
        [FunctionName("RepoProcessor")]
        public async Task RunAsync(
            [TimerTrigger("0 30 3 * * *", RunOnStartup = true)] TimerInfo myTimer,
            [Queue("commitsqueue"), StorageAccount("AzureWebJobsStorage")] ICollector<string> queue,
            ILogger log)
        {
            // Get the Repository and the most recent commit to master
            var repo = await _gitHubClient.Repository.Get("chadwickbureau", "baseballdatabank");
            var masterBranch = await _gitHubClient.Repository.Branch.Get(repo.Id, repo.DefaultBranch);
            var recentCommit = await _gitHubClient.Repository.Commit.Get(repo.Id, masterBranch.Commit.Sha);
            
            // Check the database to see if the commit has been processed
            var lastCommitProcessed =
                await _dbContext.CommitProcessorJobs.FirstOrDefaultAsync(c => c.CommitHash == recentCommit.Sha);
            
            // If the commit hasn't been processed yet, process it
            if (lastCommitProcessed == null)
            {
                var commit = new CommitProcessorJob
                {
                    CommitHash = recentCommit.Sha,
                    Status = ProcessorStatuses.Pending
                };
                await _dbContext.CommitProcessorJobs.AddAsync(commit);
                await _dbContext.SaveChangesAsync();
                queue.Add(commit.Id.ToString());
            }
        }
    }
}