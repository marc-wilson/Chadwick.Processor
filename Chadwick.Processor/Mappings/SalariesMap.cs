using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class SalariesMap : ClassMap<Salaries>
    {
        public SalariesMap()
        {
            Map( f => f.YearId).Name("yearID");
            Map( f => f.TeamId).Name("teamID");
            Map( f => f.LeagueId).Name("lgID");
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.Salary).Name("salary");
        }
    }
}