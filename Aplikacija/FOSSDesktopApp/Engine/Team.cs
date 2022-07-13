using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace FOSSDesktopApp.Engine
{
    public class Team : IDataBaseCommunication
    {

        #region Attributes

        private int iDclub;
        string clubname;
        Player[] players;
        int teamsize = 0;
        Player capitain;
        Trainer trainer;
        int wins;
        int losses;
        int draws;

        #endregion

        #region Constructor

        public Team() {
            wins = 0;
            losses = 0;
            draws = 0;
            trainer = null;
            players = new Player[12];
            teamsize = 0;
            this.teamsize = countPlayers();

        }

        public Team(string name, Trainer t)
        {
            this.clubname = name;
            wins = 0;
            losses = 0;
            draws = 0;
            trainer = t;
            players = new Player[12];
            teamsize = 0;
            this.teamsize = countPlayers();

        }

        public Team(int dclub, string name, Player[] players, Player capitain, Trainer trainer)
        {
            this.IDclub = dclub;
            this.clubname = name;
            this.players = players;
            this.capitain = capitain;
            this.trainer = trainer;
            this.teamsize = countPlayers();
            this.FindAndSetCaptain();
        }

        public void FindAndSetCaptain()
        {
            Player tmpPlayer = null ;
            for (int i = 0; i < teamsize; i++)
                if (players[i].Captain)
                {
                    tmpPlayer = players[i];
                    break;
                }
            if(tmpPlayer == null)
            {
               // MessageBox.Show("NE POSTOJI KAPITEN");
                return;
            }

            this.setCapitain(tmpPlayer);
        }

        public void GetAndSetPlayers(Player[] players)
        {
            this.players = players;
            this.teamsize = this.players.Length;
        }

        #endregion

        #region Methods

        public void addPlayer(Player player)
        {
            if (teamsize == 12) //MOZDA OVDE TREBA > 11
                return;

            players[teamsize] = player;
            teamsize++;
        }
        public int countPlayers()
        {
            int count = 0;
            for(int i = 0; i < this.players.Length; i++)
            {
                if (this.players[i] != null)
                    count++;
            }
            return count;
        }
        public bool deletePlayer(Player player) //PROVERI OVU FUNKCIJU, JA SAM JE NAPISAO I RADI - FILIP
        {
            int index = -1;
            for(int i = 0; i< teamsize; i++)
                if(players[i].Num == player.Num)
                {
                    index = i;
                    break;
                }
            if (index == -1)
                return false;
            for (; index < teamsize-1;)
                players[index] = players[++index];
            players[index] = null;
            teamsize--;
            return true;


            //OVO MI TREBA VEKI
        }
        public Player FindPlayer(string number) //OVO SAM DODAO VEKI, TREBALO BI DA JE U REDU FUNKCIJA
        {
            for (int i = 0; i < this.players.Length; i++)
                if(players[i] != null)
                    if(players[i].Num.ToString() == number)
                         return players[i];
            return null;   
            // return Players.Find(item => item.Name == selectedTeam); 
        }

        public Player FindCapitain()
        {
            for(int i = 0; i < this.TeamSize; i++)
            {
                if (players[i].Captain)
                {
                    return players[i];
                }
            }
            return null;
        }
        public bool UpdatePlayer(Player oldPlayer, Player newPlayer) //OVO SAM DODAO VEKI, TREBALO BI DA JE U REDU FUNKCIJA
        {
            for (int i = 0; i < teamsize; i++)
                if (players[i].Num == oldPlayer.Num)
                {
                    players[i] = newPlayer;
                    return true;
                }
            return false; 
        }

        #endregion
        #region Properties

        public void chnageTrainer(Trainer trainer)
        {
            this.trainer = trainer;
        }

        public void setCapitain(Player player)
        {
            Player found = this.FindPlayer(player.Num.ToString());
            if (found == null)
                return;

            for(int i = 0; i< teamsize; i++)
            {
                if (players[i].Captain == true)
                    players[i].Captain = false;
            }
            if(capitain != null)
                capitain.Captain = false;

            capitain = player;
            capitain.Captain = true;
        }

        public int registerWin()
        {
            return wins++;
        }

        public int registerLoss()
        {
            return losses++;
        }

        public int registerDraw()
        {
            return draws++;
        }

        public string ClubName
        {
            get { return clubname; }
            set { clubname = value; }
        }


        public Player Capitain 
        {
            get { return capitain; }
            set { capitain = value; }
        }

        public Trainer Trainer
        {   
           get { return trainer; }
            set { trainer = value; }
        }

        public Player[] Players
        {
            get { return players; }
            set { players = value; }
        }
		
		public int TeamSize
		{
			get { return this.teamsize; }
            set { this.teamsize = value; }
		}

        public int IDclub { get => iDclub; set => iDclub = value; }

        #endregion
        #region DBMethods
        public async Task<bool> SaveToDB()
        {
            string link = DBLinks.TeamPostLink;
            TeamModel tm = new TeamModel(this);

            string json = JsonSerializer.Serialize(tm);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            Console.WriteLine(data.Headers);

            var url = link;

            HttpClientHandler handler = new HttpClientHandler();

            var client = new HttpClient(handler);

            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            var res = await client.PostAsync(url, data).ConfigureAwait(false);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateToDB(Team oldTeam)
        {
            string link = DBLinks.TeamUpdateLink + oldTeam.ClubName;
            TeamModel tm = new TeamModel(this);

            string json = JsonSerializer.Serialize(tm);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            Console.WriteLine(data.Headers);

            var url = link;

            HttpClientHandler handler = new HttpClientHandler();

            var client = new HttpClient(handler);

            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            var res = await client.PutAsync(url, data).ConfigureAwait(false);
            return res.IsSuccessStatusCode;
        }


        public async Task<bool> DeleteFromDB()
        {
            string link = DBLinks.teamDeleteLink;
            TeamModel tm = new TeamModel(this);

            string json = JsonSerializer.Serialize(tm);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            Console.WriteLine(data.Headers);

            var url = link;

            HttpClientHandler handler = new HttpClientHandler();

            var client = new HttpClient(handler);

            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            var res = await client.PostAsync(url, data).ConfigureAwait(false);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> LoadFromDB()
        {
            string link = DBLinks.TeamGetLink;

            HttpClientHandler handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };


            HttpClient client = new HttpClient(handler);
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, link);
            req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage msg = await client.GetAsync(link);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var s = await msg.Content.ReadAsStringAsync();
            var model = JsonSerializer.Deserialize<TeamModel>(s, options);

            ClubName = model.ClubName;
            Trainer = model.Trainer;

            players = model.Players;
            capitain = model.Capitain;

            return msg.IsSuccessStatusCode;
        }

        #endregion


    }

    #region Model
    class TeamModel
    {

        public TeamModel()
        {

        }
        public TeamModel(Team team)
        {
            IDclub = team.IDclub;
            ClubName = team.ClubName;
            Trainer = team.Trainer;
            Players = team.Players;
        }
        public int IDclub { get; set; }
        public Player[] Players { get; set; }
        public string ClubName { get; set; }

        public Player Capitain { get; set; }

        public Trainer Trainer { get; set; }

    }
    #endregion
}
