using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class ParksMap : ClassMap<Parks>
    {
        public ParksMap()
        {
            Map( f => f.ParkKey).Name("park.key");
            Map( f => f.ParkName).Name("park.name");
            Map( f => f.ParkAlias).Name("park.alias");
            Map( f => f.City).Name("city");
            Map( f => f.State).Name("state");
            Map( f => f.Country).Name("country");
        }
    }
}