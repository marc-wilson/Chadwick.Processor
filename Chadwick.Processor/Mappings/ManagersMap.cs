using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class ManagersMap : ClassMap<Managers>
    {
        public ManagersMap()
        {
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.YearId).Name("yearID");
            Map( f => f.TeamId).Name("teamID");
            Map( f => f.LeagueId).Name("lgID");
            Map( f => f.ManagerialOrder).Name("inseason");
            Map( f => f.Games).Name("G");
            Map( f => f.Wins).Name("W");
            Map( f => f.Losses).Name("L");
            Map( f => f.Rank).Name("rank");
            Map( f => f.PlayerManager).Name("plyrMgr");
        }
    }
}