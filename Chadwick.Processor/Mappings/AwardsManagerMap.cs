using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class AwardsManagerMap : ClassMap<AwardsManager>
    {
        public AwardsManagerMap()
        {
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.AwardName).Name("awardID");
            Map( f => f.YearId).Name("yearID");
            Map( f => f.LeagueId).Name("lgID");
            Map( f => f.Tie).Name("tie");
            Map( f => f.Notes).Name("notes");
        }
    }
}