using System;
using System.Collections.Generic;
using Chadwick.Database;
using Chadwick.Database.Models;
using Chadwick.Processor.Mappings;
using CsvHelper;

namespace Chadwick.Processor.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// CsvHelper extension for obfuscate this switch statement.
        /// </summary>
        /// <param name="csv"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static IEnumerable<object> GetRecordsByType(this CsvReader csv, string fileName)
        {
            switch (fileName.ToLower())
            {
                case "allstarfull.csv":
                    csv.Configuration.RegisterClassMap<AllStarFullMap>();
                    return csv.GetRecords<AllStarFull>();
                case "appearances.csv":
                    csv.Configuration.RegisterClassMap<AppearancesMap>();
                    return csv.GetRecords<Appearance>();
                case "awardsmanagers.csv":
                    csv.Configuration.RegisterClassMap<AwardsManagerMap>();
                    return csv.GetRecords<AwardsManager>();
                case "awardsplayers.csv":
                    csv.Configuration.RegisterClassMap<AwardsPlayerMap>();
                    return csv.GetRecords<AwardsPlayer>();
                case "awardssharemanagers.csv":
                    csv.Configuration.RegisterClassMap<AwardsShareManagerMap>();
                    return csv.GetRecords<AwardsShareManager>();
                case "awardsshareplayers.csv":
                    csv.Configuration.RegisterClassMap<AwardsSharePlayerMap>();
                    return csv.GetRecords<AwardsSharePlayer>();
                case "batting.csv":
                    csv.Configuration.RegisterClassMap<BattingMap>();
                    return csv.GetRecords<Batting>();
                case "battingpost.csv":
                    csv.Configuration.RegisterClassMap<BattingPostMap>();
                    return csv.GetRecords<BattingPost>();
                case "collegeplaying.csv":
                    csv.Configuration.RegisterClassMap<CollegePlayingMap>();
                    return csv.GetRecords<CollegePlaying>();
                case "fielding.csv":
                    csv.Configuration.RegisterClassMap<FieldingMap>();
                    return csv.GetRecords<Fielding>();
                case "fieldingof.csv":
                    csv.Configuration.RegisterClassMap<FieldingOFMap>();
                    return csv.GetRecords<FieldingOF>();
                case "fieldingofsplit.csv":
                    csv.Configuration.RegisterClassMap<FieldingOFSplitMap>();
                    return csv.GetRecords<FieldingOFSplit>();
                case "fieldingpost.csv":
                    csv.Configuration.RegisterClassMap<FieldingPostMap>();
                    return csv.GetRecords<FieldingPost>();
                case "halloffame.csv":
                    csv.Configuration.RegisterClassMap<HallOfFameMap>();
                    return csv.GetRecords<HallOfFame>();
                case "homegames.csv":
                    csv.Configuration.RegisterClassMap<HomeGamesMap>();
                    return csv.GetRecords<HomeGames>();
                case "managers.csv":
                    csv.Configuration.RegisterClassMap<ManagersMap>();
                    return csv.GetRecords<Managers>();
                case "managershalf.csv":
                    csv.Configuration.RegisterClassMap<ManagersHalfMap>();
                    return csv.GetRecords<ManagersHalf>();
                case "parks.csv":
                    csv.Configuration.RegisterClassMap<ParksMap>();
                    return csv.GetRecords<Parks>();
                case "people.csv":
                    csv.Configuration.RegisterClassMap<PeopleMap>();
                    return csv.GetRecords<People>();
                case "pitching.csv":
                    csv.Configuration.RegisterClassMap<PitchingMap>();
                    return csv.GetRecords<Pitching>();
                case "pitchingpost.csv":
                    csv.Configuration.RegisterClassMap<PitchingPostMap>();
                    return csv.GetRecords<PitchingPost>();
                case "salaries.csv":
                    csv.Configuration.RegisterClassMap<SalariesMap>();
                    return csv.GetRecords<Salaries>();
                case "schools.csv":
                    csv.Configuration.RegisterClassMap<SchoolsMap>();
                    return csv.GetRecords<Schools>();
                case "seriespost.csv":
                    csv.Configuration.RegisterClassMap<SeriesPostMap>();
                    return csv.GetRecords<SeriesPost>();
                case "teams.csv":
                    csv.Configuration.RegisterClassMap<TeamsMap>();
                    return csv.GetRecords<Teams>();
                case "teamsfranchises.csv":
                    csv.Configuration.RegisterClassMap<TeamsFranchisesMap>();
                    return csv.GetRecords<TeamsFranchises>();
                case "teamshalf.csv":
                    csv.Configuration.RegisterClassMap<TeamsHalfMap>();
                    return csv.GetRecords<TeamsHalf>();
            }

            return null;
        }

        public static Type GetEntityByFileName(this ChadwickDbContext dbContext, string fileName)
        {
            return fileName.ToLower() switch
            {
                "allstarfull.csv" => typeof(AllStarFull),
                "appearances.csv" => typeof(Appearance),
                "awardsmanagers.csv" => typeof(AwardsManager),
                "awardsplayers.csv" => typeof(AwardsPlayer),
                "awardssharemanagers.csv" => typeof(AwardsShareManager),
                "awardsshareplayers.csv" => typeof(AwardsSharePlayer),
                "batting.csv" => typeof(Batting),
                "battingpost.csv" => typeof(BattingPost),
                "collegeplaying.csv" => typeof(CollegePlaying),
                "fielding.csv" => typeof(Fielding),
                "fieldingof.csv" => typeof(FieldingOF),
                "fieldingofsplit.csv" => typeof(FieldingOFSplit),
                "fieldingpost.csv" => typeof(FieldingPost),
                "halloffame.csv" => typeof(HallOfFame),
                "homegames.csv" => typeof(HomeGames),
                "managers.csv" => typeof(Managers),
                "managershalf.csv" => typeof(ManagersHalf),
                "parks.csv" => typeof(Parks),
                "people.csv" => typeof(People),
                "pitching.csv" => typeof(Pitching),
                "pitchingpost.csv" => typeof(PitchingPost),
                "salaries.csv" => typeof(Salaries),
                "schools.csv" => typeof(Schools),
                "seriespost.csv" => typeof(SeriesPost),
                "teams.csv" => typeof(Teams),
                "teamsfranchises.csv" => typeof(TeamsFranchises),
                "teamshalf.csv" => typeof(TeamsHalf),
                _ => null
            };
        }
    }
}