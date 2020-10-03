using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class BattingPostMap : ClassMap<BattingPost>
    {
        public BattingPostMap()
        {
            Map( f => f.YearId).Name("yearID");
            Map( f => f.LevelOfPlayoffs).Name("round");
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.TeamId).Name("teamID");
            Map( f => f.LeagueId).Name("lgID");
            Map( f => f.Games).Name("G");
            Map( f => f.AtBats).Name("AB");
            Map( f => f.Runs).Name("R");
            Map( f => f.Hits).Name("H");
            Map( f => f.Doubles).Name("2B");
            Map( f => f.Triples).Name("3B");
            Map( f => f.HomeRuns).Name("HR");
            Map( f => f.RunsBattedIn).Name("RBI");
            Map( f => f.StolenBases).Name("SB");
            Map( f => f.CaughtStealing).Name("CS");
            Map( f => f.BaseOnBalls).Name("BB");
            Map( f => f.Strikeouts).Name("SO");
            Map( f => f.IntentionalWalks).Name("IBB");
            Map( f => f.HitByPitch).Name("HBP");
            Map( f => f.Sacrifices).Name("SH");
            Map( f => f.SacrificeFlies).Name("SF");
            Map( f => f.GroundedIntoDoublePlays).Name("GIDP");
        }
        
    }
}