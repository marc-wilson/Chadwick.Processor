using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class ManagersHalfMap : ClassMap<ManagersHalf>
    {
        public ManagersHalfMap()
        {
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.YearId).Name("yearID");
            Map( f => f.TeamId).Name("teamID");
            Map( f => f.LeagueId).Name("lgID");
            Map( f => f.ManagerialOrder).Name("inseason");
            Map( f => f.Half).Name("half");
            Map( f => f.Games).Name("G");
            Map( f => f.Wins).Name("W");
            Map( f => f.Losses).Name("L");
            Map( f => f.Rank).Name("rank");
        }
    }
}