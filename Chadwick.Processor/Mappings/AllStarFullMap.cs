using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class AllStarFullMap : ClassMap<AllStarFull>
    {
        public AllStarFullMap()
        {
            Map(a => a.PlayerId).Name("playerID");
            Map(a => a.YearId).Name("yearID");
            Map(a => a.GameNumber).Name("gameNum");
            Map(a => a.GameId).Name("gameID");
            Map(a => a.TeamId).Name("teamID");
            Map(a => a.LeagueId).Name("lgID");
            Map(a => a.GamesPlayed).Name("GP");
            Map(a => a.StartingPosition).Name("startingPos");
        }
    }
}