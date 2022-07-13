using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Engine
{
    static public class DBLinks
    {
        private static string addressAndPost = "http://localhost:5000/foss/";
        private static string adminGetLink= addressAndPost + "loginAdmin/";
        private static string adminAssignToCompetitionLink = addressAndPost + "assignAdminToTournir/";
        private static string adminUnAssignToCompetitionLink = addressAndPost + "unAssignAdminToTournir/";
        private static string adminPostLink= addressAndPost + "insertAdmin";

        private static string drawMatchesLink = addressAndPost + "returnMatchesDraw/";


        private static string competitionGetLink = addressAndPost + "returnTournir/";
        private static string competitionPostLink = addressAndPost + "insertTournir/";
        private static string competitionPutLink = addressAndPost + "insertTournirMatches";
        private static string competitionUpdateLink = addressAndPost + "updateTournir";

        private static string competitionStatisticsUpdate = addressAndPost + "updateClubStat";
        private static string competitionDeleteLink = addressAndPost + "deleteTournir";

        private static string adminDeleteLink=addressAndPost+"deleteAdmin";

        private static string matchGetLink = addressAndPost + "returnMatches";
        private static string matchPostLink = addressAndPost + "insertMatch";
        private static string matchPutLink = addressAndPost + "updateMatch"; //OVO SAM JA DODAO - FILIP
        private static string matchAssingLink = addressAndPost + "assignClubMatch";

        private static string organizerGetLink = addressAndPost + "loginOrganisator/";
        private static string organizerPostLink = addressAndPost + "insertOrganisator";

        private static string playerGetLink;
        private static string playerPostLink;
        private static string playerPutLink = addressAndPost + "updateMatch";
        private static string playerDeleteLink;
        private static string playerStatisticsGetLink = addressAndPost + "returnPlayerStat/";
        private static string playerStatisticsPutLink = addressAndPost + "updatePlayerStat";

        private static string refereeGetLink;
        private static string refereePostLink = addressAndPost + "insertReferee";
        private static string refereeListGetLink = addressAndPost + "returnReferees";
        private static string refereeListPostLink = addressAndPost + "";

        public static string teamListGetLink = addressAndPost + "returnClubs";
        public static string teamListPostLink = addressAndPost + "";

        //RefereeList - GET
        //TeamList - GET
        private static string teamGetLink;
        private static string teamPostLink=addressAndPost + "insertClub";
        private static string teamUpdateLink = addressAndPost + "updateClub/";
        public static string teamDeleteLink = addressAndPost + "deleteClub";
        private static string teamStatisticsGetLink = addressAndPost + "returnClubStat/";
        private static string teamStatisticsPostLink = addressAndPost + "updateClubStat";
        static DBLinks()
        {

        }

        public static string AdminGetLink { get => adminGetLink; }
        public static string AdminPostLink { get => adminPostLink; }
        public static string CompetitionGetLink { get => competitionGetLink;}
        public static string CompetitionPostLink { get => competitionPostLink; }
        public static string CompetitionPutLink { get => competitionPutLink; }
        public static string CompetitionDeleteLink { get => competitionDeleteLink; }
        public static string AdminDeleteLink { get => adminDeleteLink; }
        public static string MatchGetLink { get => matchGetLink; }
        public static string MatchPostLink { get => matchPostLink; }
        public static string MatchPutLink { get => matchPutLink; }
        public static string OrganizerGetLink { get => organizerGetLink; }
        public static string OrganizerPostLink { get => organizerPostLink; }
        public static string PlayerGetLink { get => playerGetLink; }
        public static string PlayerPostLink { get => playerPostLink; }
        public static string PlayerPutLink { get => playerPutLink; }
        public static string PlayerDeleteLink { get => playerDeleteLink; }
        public static string PlayerStatisticsGetLink { get => playerStatisticsGetLink; }
        public static string PlayerStatisticsPostLink { get => playerStatisticsPutLink; }
        public static string RefereeGetLink { get => refereeGetLink; }
        public static string RefereePostLink { get => refereePostLink; }
        public static string TeamGetLink { get => teamGetLink; }
        public static string TeamPostLink { get => teamPostLink; }
        public static string TeamStatisticsGetLink { get => teamStatisticsGetLink; }
        public static string TeamStatisticsPostLink { get => teamStatisticsPostLink; }
        public static string RefereeListGetLink { get => refereeListGetLink;}
        public static string AdminAssignToCompetitionLink { get => adminAssignToCompetitionLink; set => adminAssignToCompetitionLink = value; }
        public static string AdminUnAssignToCompetitionLink { get => adminUnAssignToCompetitionLink; set => adminUnAssignToCompetitionLink = value; }
        public static string TeamUpdateLink { get => teamUpdateLink; set => teamUpdateLink = value; }
        public static string CompetitionStatisticsUpdate { get => competitionStatisticsUpdate; set => competitionStatisticsUpdate = value; }
        public static string MatchAssingLink { get => matchAssingLink; set => matchAssingLink = value; }
        public static string CompetitionUpdateLink { get => competitionUpdateLink; set => competitionUpdateLink = value; }
        public static string DrawMatchesLink { get => drawMatchesLink; set => drawMatchesLink = value; }
    }
}
