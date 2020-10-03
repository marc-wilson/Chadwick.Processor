using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class TeamsHalfMap : ClassMap<TeamsHalf>
    {
        public TeamsHalfMap()
        {
            Map( f => f.YearId).Name("yearID");
            Map( f => f.LeagueId).Name("lgID");
            Map( f => f.TeamId).Name("teamID");
            Map( f => f.Half).Name("Half");
            Map( f => f.DivisionId).Name("divID");
            Map( f => f.DivisionWin).Name("DivWin");
            Map( f => f.Rank).Name("Rank");
            Map( f => f.Games).Name("G");
            Map( f => f.Wins).Name("W");
            Map( f => f.Losses).Name("L");
        }
    }
}