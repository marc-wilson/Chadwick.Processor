using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class AppearancesMap : ClassMap<Appearance>
    {
        public AppearancesMap()
        {
            Map( f => f.YearId).Name("yearID");
            Map( f => f.TeamId).Name("teamID");
            Map( f => f.LeagueId).Name("lgID");
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.TotalGamesPlayed).Name("G_all");
            Map( f => f.GamesStarted).Name("GS");
            Map( f => f.GamesBatted).Name("G_batting");
            Map( f => f.GamesDefense).Name("G_defense");
            Map( f => f.GamesAsPitcher).Name("G_p");
            Map( f => f.GamesAsCatcher).Name("G_c");
            Map( f => f.GamesAsFirstBaseman).Name("G_1b");
            Map( f => f.GamesAsSecondBaseman).Name("G_2b");
            Map( f => f.GamesAsThirdBaseman).Name("G_3b");
            Map( f => f.GamesAsShortStop).Name("G_ss");
            Map( f => f.GamesAsLeftFielder).Name("G_lf");
            Map( f => f.GamesAsCenterFielder).Name("G_cf");
            Map( f => f.GamesAsRightFielder).Name("G_rf");
            Map( f => f.GamesAsOutfielder).Name("G_of");
            Map( f => f.GamesAsDesignatedHitter).Name("G_dh");
            Map( f => f.GamesAsPinchHitter).Name("G_ph");
            Map( f => f.GamesAsPinchRunner).Name("G_pr");
        }
    }
}