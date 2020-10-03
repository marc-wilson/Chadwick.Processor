using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class SeriesPostMap : ClassMap<SeriesPost>
    {
        public SeriesPostMap()
        {
            Map( f => f.YearId).Name("yearID");
            Map( f => f.LevelOfPlayoffs).Name("round");
            Map( f => f.WinningTeamId).Name("teamIDwinner");
            Map( f => f.WinningLeagueId).Name("lgIDwinner");
            Map( f => f.LoserTeamId).Name("teamIDloser");
            Map( f => f.LoserLeagueId).Name("lgIDloser");
            Map( f => f.Wins).Name("wins");
            Map( f => f.Losses).Name("losses");
            Map( f => f.Ties).Name("ties");
        }
    }
}