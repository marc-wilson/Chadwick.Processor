using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class TeamsMap : ClassMap<Teams>
    {
        public TeamsMap()
        {
            Map( f => f.LeagueId).Name("lgID");
            Map( f => f.TeamId).Name("teamID");
            Map( f => f.FranchiseId).Name("franchID");
            Map( f => f.DivisionId).Name("divID");
            Map( f => f.Rank).Name("Rank");
            Map( f => f.Games).Name("G");
            Map( f => f.HomeGames).Name("Ghome");
            Map( f => f.Wins).Name("W");
            Map( f => f.Losses).Name("L");
            Map( f => f.DivisionWin).Name("DivWin");
            Map( f => f.WildCardWinner).Name("WCWin");
            Map( f => f.LeagueWin).Name("LgWin");
            Map( f => f.WorldSeriesWin).Name("WSWin");
            Map( f => f.Runs).Name("R");
            Map( f => f.AtBats).Name("AB");
            Map( f => f.Hits).Name("H");
            Map( f => f.Doubles).Name("2B");
            Map( f => f.Triples).Name("3B");
            Map( f => f.HomeRuns).Name("HR");
            Map( f => f.Walks).Name("BB");
            Map( f => f.Strikeouts).Name("SO");
            Map( f => f.StolenBases).Name("SB");
            Map( f => f.CaughtStealing).Name("CS");
            Map( f => f.HitByPitch).Name("HBP");
            Map( f => f.SacrificeFlies).Name("SF");
            Map( f => f.RunsAllowed).Name("RA");
            Map( f => f.EarnedRunsAllowed).Name("ER");
            Map( f => f.EarnedRunsAverage).Name("ERA");
            Map( f => f.CompleteGames).Name("CG");
            Map( f => f.Shutouts).Name("SHO");
            Map( f => f.Saves).Name("SV");
            Map( f => f.OutsPitched).Name("IPouts");
            Map( f => f.HitsAllowed).Name("HA");
            Map( f => f.HomeRunsAllowed).Name("HRA");
            Map( f => f.WalksAllowed).Name("BBA");
            Map( f => f.StrikeoutsByPitchers).Name("SOA");
            Map( f => f.Errors).Name("E");
            Map( f => f.DoublePlays).Name("DP");
            Map( f => f.FieldingPercentage).Name("FP");
            Map( f => f.Name).Name("name");
            Map( f => f.Ballpark).Name("park");
            Map( f => f.Attendance).Name("attendance");
            Map( f => f.ThreeYearParkFactorForBatters).Name("BPF");
            Map( f => f.ThreeYearParkFactorForPitchers).Name("PPF");
            Map( f => f.BaseballReferenceTeamId).Name("teamIDBR");
            Map( f => f.LahmanTeamId).Name("teamIDlahman45");
            Map( f => f.RetrosheetTeamId).Name("teamIDretro");
        }
    }
}