using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class AwardsSharePlayerMap : ClassMap<AwardsSharePlayer>
    {
        public AwardsSharePlayerMap()
        {
            Map( f => f.AwardName).Name("awardID");
            Map( f => f.YearId).Name("yearID");
            Map( f => f.LeagueId).Name("lgID");
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.PointsWon).Name("pointsWon");
            Map( f => f.PointsMax).Name("pointsMax");
            Map( f => f.VotesFirst).Name("votesFirst");
        }
    }
}