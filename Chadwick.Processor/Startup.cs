using System;
using Chadwick.Database;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Octokit;

[assembly: FunctionsStartup(typeof(Chadwick.Processor.Startup))]

namespace Chadwick.Processor
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddDbContext<ChadwickDbContext>(options =>
                options.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionStrings:DefaultConnection")));
            builder.Services.AddTransient(options => new GitHubClient(new ProductHeaderValue("chadwick.database")));
        }
    }
}