using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class FieldingOFMap : ClassMap<FieldingOF>
    {
        public FieldingOFMap()
        {
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.YearId).Name("yearID");
            Map( f => f.Stint).Name("stint");
            Map( f => f.GamesPlayedInLeftField).Name("Glf");
            Map( f => f.GamesPlayedInCenterField).Name("Gcf");
            Map( f => f.GamesPlayedInRightField).Name("Grf");
        }
    }
}