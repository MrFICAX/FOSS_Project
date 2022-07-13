using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Headers;

namespace FOSSDesktopApp.Engine
{
    public class TeamStatistics : IDataBaseCommunication
    {
        #region Attributes
        private int iDcstatistic;
        private string competition;
        private Team clubStat;
        private int wins;
        private int loses;
        private int draws;
        private int goalsDifference;

        #endregion
        #region Constructors

        public TeamStatistics()
        {

        }
        public TeamStatistics(Competition comp, Team team)
        {
            competition = comp.Name;
            this.clubStat = team;
        }

        #endregion

        #region Properties

        public int Wins
        {
            get { return wins; }
            set { wins = value; }
        }
        public int Loses
        {
            get { return loses; }
            set { loses = value; }
        }
        public int Draws
        {
            get { return draws; }
            set { draws = value; }
        }

        public int numOfGamesPlayed
        {
            get { return wins + loses + draws; }
        }

        public Team ClubStat
        {
            get { return clubStat; }
            set { clubStat = value; }
        }

        public int IDcstatistic { get => iDcstatistic; set => iDcstatistic = value; }
        public int GoalsDifference { get => goalsDifference; set => goalsDifference = value; }

        #endregion
        #region DBMethods

        public async Task<bool> LoadFromDB()
        {
            string link = DBLinks.TeamStatisticsGetLink + this.clubStat.ClubName; 

            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;


            HttpClient client = new HttpClient(handler);
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, link);
            req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage msg = await client.GetAsync(link);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var s = await msg.Content.ReadAsStringAsync();
            var ts = JsonSerializer.Deserialize<TeamStatistics>(s, options);

            Wins = ts.Wins;
            Loses = ts.Loses;
            Draws = ts.Draws;
            competition = ts.competition;
            clubStat = ts.ClubStat;

            return msg.IsSuccessStatusCode;
        }

        public async Task<bool> SaveToDB()
        {
            string link = DBLinks.TeamStatisticsPostLink;

            string json = JsonSerializer.Serialize(this);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            Console.WriteLine(data.Headers);

            var url = link;

            HttpClientHandler handler = new HttpClientHandler();

            var client = new HttpClient(handler);

            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            var res = await client.PutAsync(url, data).ConfigureAwait(false);
            return res.IsSuccessStatusCode;
        }
        #endregion
    }
}
