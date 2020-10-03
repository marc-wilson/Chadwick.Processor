using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class CollegePlayingMap : ClassMap<CollegePlaying>
    {
        public CollegePlayingMap()
        {
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.SchoolId).Name("schoolID");
            Map( f => f.YearId).Name("yearID");
        }
    }
}