using System.Threading.Tasks;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using Chadwick.Database;
using Chadwick.Processor.Extensions;
using CsvHelper;
using EFCore.BulkExtensions;
using Microsoft.Azure.WebJobs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Chadwick.Processor.Functions
{
    public class CsvProcessor
    {
        private readonly ChadwickDbContext _dbContext;

        public CsvProcessor(ChadwickDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [FunctionName("CsvProcessor")]
        public async Task RunAsync([QueueTrigger("csvqueue", Connection = "AzureWebJobsStorage")]
            string csvJobId, ILogger log)
        {
            // Get the CSV Job
            var csvJob = await _dbContext.CsvProcessorJobs.FirstOrDefaultAsync(c => c.Id == Convert.ToInt32(csvJobId));
            if (csvJob == null) throw new Exception("Not Found");

            log.LogInformation($"Processing {csvJob.FileName}");

            // Download the CSV abd upload to db
            var stream = await new HttpClient().GetStreamAsync(csvJob.DownloadUrl);
            var reader = new StreamReader(stream);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            try
            {
                var records = csv.GetRecordsByType(csvJob.FileName).ToList();
                await _dbContext.TruncateAsync(_dbContext.GetEntityByFileName(csvJob.FileName));
                await _dbContext.BulkInsertAsync(records);
                log.LogInformation($"Completed {csvJob.FileName} with {records.Count} items");

                csvJob.Finished = DateTime.Now;
                csvJob.Status = ProcessorStatuses.Finished;
                _dbContext.CsvProcessorJobs.Update(csvJob);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                csvJob.Finished = DateTime.Now;
                csvJob.Status = ex.Message;
                _dbContext.CsvProcessorJobs.Update(csvJob);
                await _dbContext.SaveChangesAsync();
                log.LogError(ex.Message);
                throw ex;
            }

            log.LogInformation(csvJob.DownloadUrl);
        }
    }
}