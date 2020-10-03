using Chadwick.Database.Models;
using CsvHelper.Configuration;

namespace Chadwick.Processor.Mappings
{
    public class HallOfFameMap : ClassMap<HallOfFame>
    {
        public HallOfFameMap()
        {
            Map( f => f.PlayerId).Name("playerID");
            Map( f => f.YearId).Name("yearID");
            Map( f => f.VotedByMethod).Name("votedBy");
            Map( f => f.TotalBallotsCast).Name("ballots");
            Map( f => f.VotesNeeded).Name("needed");
            Map( f => f.TotalVotesReceived).Name("votes");
            Map( f => f.Inducted).Name("inducted");
            Map( f => f.Category).Name("category");
            Map( f => f.NeededNote).Name("needed_note");
        }
    }
}