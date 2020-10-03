using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class TeamsFranchisesMap : ClassMap<TeamsFranchises>
    {
        public TeamsFranchisesMap()
        {
            Map( f => f.FranchiseId).Name("franchID");
            Map( f => f.Name).Name("franchName");
            Map( f => f.Active).Name("active");
            Map( f => f.NationalAssociationFranchiseId).Name("NAassoc");
        }
    }
}