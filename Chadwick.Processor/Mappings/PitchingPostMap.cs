using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class PitchingPostMap : ClassMap<PitchingPost>
    {
        public PitchingPostMap()
        {
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.YearId).Name("yearID");
            Map( f => f.LevelOfPlayoffs).Name("round");
            Map( f => f.TeamId).Name("teamID");
            Map( f => f.LeagueId).Name("lgID");
            Map( f => f.Wins).Name("W");
            Map( f => f.Losses).Name("L");
            Map( f => f.Games).Name("G");
            Map( f => f.GameStarts).Name("GS");
            Map( f => f.CompleteGames).Name("CG");
            Map( f => f.Shutouts).Name("SHO");
            Map( f => f.Saves).Name("SV");
            Map( f => f.OutsPitched).Name("IPouts");
            Map( f => f.Hits).Name("H");
            Map( f => f.EarnedRuns).Name("ER");
            Map( f => f.HomeRuns).Name("HR");
            Map( f => f.Walks).Name("BB");
            Map( f => f.Strikeouts).Name("SO");
            Map( f => f.OpponentBattingAverage).Name("BAOpp");
            Map( f => f.EarnedRunsAverage).Name("ERA");
            Map( f => f.IntentionalWalks).Name("IBB");
            Map( f => f.WildPitches).Name("WP");
            Map( f => f.BattersHitByPitch).Name("HBP");
            Map( f => f.Balks).Name("BK");
            Map( f => f.BattersFaced).Name("BFP");
            Map( f => f.GamesFinished).Name("GF");
            Map( f => f.RunsAllowed).Name("R");
            Map( f => f.SacrificeHitsAllowed).Name("SH");
            Map( f => f.SacrificeFliesAllowed).Name("SF");
            Map( f => f.GroundedIntoDoublePlays).Name("GIDP");
        }
    }
}