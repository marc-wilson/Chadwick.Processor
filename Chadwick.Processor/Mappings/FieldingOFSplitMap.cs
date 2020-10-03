using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class FieldingOFSplitMap : ClassMap<FieldingOFSplit>
    {
        public FieldingOFSplitMap()
        {
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.YearId).Name("yearID");
            Map( f => f.Stint).Name("stint");
            Map( f => f.TeamId).Name("teamID");
            Map( f => f.LeagueId).Name("lgID");
            Map( f => f.Games).Name("G");
            Map( f => f.GameStarts).Name("GS");
        }
    }
}