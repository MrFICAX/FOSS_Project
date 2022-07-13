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
    public class PlayerStatistics : IDataBaseCommunication
    {

        #region Attibutes

        private int iDpstatistic;
        private int goals;
        private int cards;
        private Player playerStat;

        #endregion

        #region Constructors

        public PlayerStatistics()
        {

        }
        public PlayerStatistics(Player p)
        {
            playerStat = p;
        }

        #endregion

        #region Properties

        public int Goals
        {
            get { return goals; }
            set { goals = value; }
        }

        public int Cards
        {
            get { return cards; }
            set { cards = value; }
        }

        public Player PlayerStat
        {
            get { return playerStat; }
            set { playerStat = value; }
        }

        public int IDpstatistic { get => iDpstatistic; set => iDpstatistic = value; }

        #endregion

        #region DBMethods
        public async Task<bool> LoadFromDB()
        {
            string link = DBLinks.PlayerStatisticsGetLink + this.playerStat.PersonName;
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            HttpClient client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, link);
            req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage msg = await client.GetAsync(link);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var s = await msg.Content.ReadAsStringAsync();
            var model = JsonSerializer.Deserialize<PlayerStatistics>(s, options);

            goals = model.Goals;
            cards = model.Cards;
            playerStat = model.PlayerStat;
            return msg.IsSuccessStatusCode;
        }

        public async Task<bool> SaveToDB()
        {
            string link = DBLinks.PlayerStatisticsPostLink;

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
