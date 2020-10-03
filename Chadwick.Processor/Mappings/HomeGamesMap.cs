using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class HomeGamesMap : ClassMap<HomeGames>
    {
        public HomeGamesMap()
        {
            Map( f => f.YearKey).Name("year.key");
            Map( f => f.LeagueKey).Name("league.key");
            Map( f => f.TeamKey).Name("team.key");
            Map( f => f.ParkKey).Name("park.key");
            Map( f => f.SpanFirst).Name("span.first");
            Map( f => f.SpanLast).Name("span.last");
            Map( f => f.Games).Name("games");
            Map( f => f.Openings).Name("openings");
            Map( f => f.Attendance).Name("attendance");
        }
    }
}