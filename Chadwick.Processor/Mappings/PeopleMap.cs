using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class PeopleMap : ClassMap<People>
    {
        public PeopleMap()
        {
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.BirthYear).Name("birthYear");
            Map( f => f.BirthMonth).Name("birthMonth");
            Map( f => f.BirthDay).Name("birthDay");
            Map( f => f.BirthCountry).Name("birthCountry");
            Map( f => f.BirthState).Name("birthState");
            Map( f => f.BirthCity).Name("birthCity");
            Map( f => f.DeathYear).Name("deathYear");
            Map( f => f.DeathMonth).Name("deathMonth");
            Map( f => f.DeathDay).Name("deathDay");
            Map( f => f.DeathCountry).Name("deathCountry");
            Map( f => f.DeathState).Name("deathState");
            Map( f => f.DeathCity).Name("deathCity");
            Map( f => f.NameFirst).Name("nameFirst");
            Map( f => f.NameLast).Name("nameLast");
            Map( f => f.NameGiven).Name("nameGiven");
            Map( f => f.Weight).Name("weight");
            Map( f => f.Height).Name("height");
            Map( f => f.Bats).Name("bats");
            Map( f => f.Throws).Name("throws");
            Map( f => f.Debut).Name("debut");
            Map( f => f.FinalGame).Name("finalGame");
            Map( f => f.RetrosheetId).Name("retroID");
            Map( f => f.BaseballReferenceId).Name("bbrefID");
        }
    }
}