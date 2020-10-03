using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class FieldingMap : ClassMap<Fielding>
    {
        public FieldingMap()
        {
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.YearId).Name("yearID");
            Map( f => f.Stint).Name("stint");
            Map( f => f.TeamId).Name("teamID");
            Map( f => f.LeagueId).Name("lgID");
            Map( f => f.Position).Name("POS");
            Map( f => f.Games).Name("G");
            Map( f => f.GameStarts).Name("GS");
            Map( f => f.TimePlayedInFieldExpressedAsOuts).Name("InnOuts");
            Map( f => f.Putouts).Name("PO");
            Map( f => f.Assists).Name("A");
            Map( f => f.Errors).Name("E");
            Map( f => f.DoublePlays).Name("DP");
            Map( f => f.PassedBalls).Name("PB");
            Map( f => f.WildPitches).Name("WP");
            Map( f => f.StolenBases).Name("SB");
            Map( f => f.CaughtStealing).Name("CS");
            Map( f => f.ZoneRating).Name("ZR");
        }
    }
}