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
    public enum Card { none, yellow, red }
    public class Player : Participaint, IDataBaseCommunication
    {

        #region Attributes
        private int goalNum;
        private int goalNumInMatch;
        private bool captain;
        private Card cards;
        private int num;
        string position;

        #endregion

        #region Constructors
        public Player()
            :base()
        {
            goalNum = 0;
            captain = false;
            cards = Card.none;
            num = 0;
            GoalNumInMatch = 0;
        }

        public Player(string name, string surname, int goalnum, string position, int number)
            :base(name, surname)
        {
            goalNum = goalnum;
            this.position = position;
            this.num = number;
            captain = false;
            cards = Card.none;
            GoalNumInMatch = 0;

        }

        #endregion

        #region Properties

        public int GoalNum
        {
            get { return goalNum; }
            set { goalNum = value; }
        }

        public bool Captain
        {
            get { return captain; }
            set { captain = value; }
        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public string Position
        {
            get { return position;  }
            set { position = value; }

        }

        public Card Cards
        {
            get { return cards; }
            set {  cards = value; }
        }

        public int GoalNumInMatch 
        { 
            get => goalNumInMatch; 
            set => goalNumInMatch = value; 
        }

        #endregion

        #region Methods

        public void setGoal()
        {
            this.goalNum++;
            this.goalNumInMatch++;
        }

        public void undoGoal()
        {
            if(this.goalNum != 0 || this.goalNumInMatch != 0)
            {
                this.goalNum--;
                this.GoalNumInMatch--;
            }
        }

        public bool setCard()
        {
            if (this.Cards == Card.none)
            {
                this.Cards = Card.yellow;
                return true;
            }
            else if (this.Cards == Card.yellow)
            {
                this.Cards = Card.red;
                return true;
            }
            else
                return false;
        }

        public bool undoCard()
        {
            if (this.Cards == Card.none)
                return false;
            else if (this.Cards == Card.red)
            {
                this.Cards = Card.yellow;
                return true;
            }
            else
            {
                this.Cards = Card.none;
                return true;
            }
        }

        #endregion

        #region DBMethods
        public async Task<bool> LoadFromDB()
        {
            string link = DBLinks.PlayerGetLink;
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;


            HttpClient client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, link);
            req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage msg = await client.GetAsync(link);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var s = await msg.Content.ReadAsStringAsync();
            var model = JsonSerializer.Deserialize<PlayerModel>(s, options);

            base.PersonName = model.PersonName;
            base.Surname = model.Surname;
            num = model.Num;
            return msg.IsSuccessStatusCode;
        }

        public async Task<bool> SaveToDB()
        {
            string link = DBLinks.PlayerPostLink;
            PlayerModel om = new PlayerModel(this);

            string json = JsonSerializer.Serialize(om);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            Console.WriteLine(data.Headers);

            var url = link;

            HttpClientHandler handler = new HttpClientHandler();

            var client = new HttpClient(handler);

            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            var res = await client.PostAsync(url, data);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateToDB()
        {
            string link = DBLinks.PlayerPutLink;
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            var client = new HttpClient(handler);
            var plModel = new PlayerModel(this);
            var jcontent = JsonSerializer.Serialize(plModel);
            var requestContent = new StringContent(jcontent, Encoding.UTF8, "application/json");
            var url = link;
            var response = await client.PutAsync(url, requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteFromDB()
        {
            string link = DBLinks.PlayerDeleteLink;
            PlayerModel om = new PlayerModel(this);

            string json = JsonSerializer.Serialize(om);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            Console.WriteLine(data.Headers);

            var url = link;

            HttpClientHandler handler = new HttpClientHandler();

            var client = new HttpClient(handler);

            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            var res = await client.PostAsync(url, data);
            return res.IsSuccessStatusCode;
        }

        #endregion

    }

    #region Model
    class PlayerModel
    {

        public PlayerModel()
        {

        }
        public PlayerModel(Player player)
        {
            PersonName = player.PersonName;
            Surname = player.Surname;
            Goals = player.GoalNum;
            Captain = player.Captain;
            Num = player.Num;
            Position = player.Position;
            Cards = player.Cards;
        }
        public string PersonName { get; set; }
        public string Surname { get; set; }
        public int Goals
        {
            get; set;
        }

        public bool Captain
        {
            get; set;
        }

        public int Num
        {
            get; set;
        }

        public string Position
        {
            get; set;

        }
        public Card Cards { get; private set; }
    }
    #endregion
}
