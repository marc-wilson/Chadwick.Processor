using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class SchoolsMap : ClassMap<Schools>
    {
        public SchoolsMap()
        {
            Map( f => f.SchoolId).Name("schoolID");
            Map( f => f.Name).Name("name_full");
            Map( f => f.City).Name("city");
            Map( f => f.State).Name("state");
            Map( f => f.Country).Name("country");
        }
    }
}