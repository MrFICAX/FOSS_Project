using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace FOSSDesktopApp.Engine
{


    enum TeamIndexer
    {
        home=0,
        away
    }
    public class Match : IDataBaseCommunication
    {
        #region attributes
        private Team[] teams;
        private Referee referee;
        private int[] scores;
        private DateTime date;
        private bool ongoing;
        private string level;
        private string specificNumber;
        private Match leftChild;
        private Match rightChild;
        private int Idmatch;

        private Team winner;

        #endregion

        #region Constructors
        public Match()
        {
            initMatch();
        }

        public Match(Team hometeam, Team awayteam, Referee referee, DateTime dt, string lvl, string spec)
        {
            initMatch();
            this.referee = referee;
            level = lvl;
            date = dt;
            teams[0] = hometeam;
            teams[1] = awayteam;
            specificNumber = spec;

        }

        public Match(int idMatch, Team hometeam, Team awayteam, Team winner, int homeGoals, int awayGoals, Referee referee, DateTime dt, string lvl, string spec, bool live)
        {
            this.IDmatch = idMatch;
            initMatch();
            this.referee = referee;
            level = lvl;
            date = dt;
            teams[0] = hometeam;
            teams[1] = awayteam;
            scores[0] = homeGoals;
            scores[1] = awayGoals;
            this.Winner = new Team();
            this.Winner = winner;
            specificNumber = spec;
            this.isOngoing = live;

        }

        #endregion

        #region Methods

        public void InputMatchInPosition(Match match, string[] s)
        {
            int level = s.Length;

            if (level == 1)
            {
                this.Teams = match.Teams;
                this.IDmatch = match.IDmatch;
                this.Referee = match.Referee;
                this.Scores = match.Scores;
                this.isOngoing = match.isOngoing;
                this.Winner = match.Winner;

                return;
            }

            if (s[1] == "1")
            {
                List<string> snew = s.ToList();
                snew.RemoveAt(1);
                this.LeftChild.InputMatchInPosition(match, snew.ToArray());
            }
            else if (s[1] == "2")
            {
                List<string> snew = s.ToList();
                snew.RemoveAt(1);
                this.RightChild.InputMatchInPosition(match, snew.ToArray());
            }
        }


        private void initMatch()
        {
            teams = new Team[2];
            scores = new int[2];
            scores[0] = 0;
            scores[1] = 0;
            ongoing = false;
            winner = null;
            //-------------OVO ISPOD SAM DODAO - FILIP
            //LeftChild = null;
            //RightChild = null;
            specificNumber = "1";
        }

        public void start()
        {
            ongoing = true;
            this.date = DateTime.Now;
        }

        public void pause()
        {
            ongoing = false;
   
        }

        public void setGoal(Team tmpTeam, Player player)
        {
            if (tmpTeam == teams[0])
            {
                scores[0]++;                
            }
            else if (tmpTeam == teams[1])
            {
                scores[1]++;
            }
            tmpTeam.FindPlayer(player.Num.ToString()).setGoal();
            if (!this.UpdateToDB().Result)
            {
                if (player.GoalNumInMatch == 0)
                    return;
                if (tmpTeam == teams[0])
                {
                    if (scores[0] != 0)
                    {
                        scores[0]--;
                    }
                }
                else if (tmpTeam == teams[1])
                {
                    if (scores[1] != 0)
                    {
                        scores[1]--;
                    }
                }
                tmpTeam.FindPlayer(player.Num.ToString()).undoGoal();
            }
           
        }

        public bool undoGoal(Team tmpTeam, Player player)
        {
            if (player.GoalNumInMatch == 0)
                return false;
            if (tmpTeam == teams[0])
            {
                if(scores[0] != 0)
                {
                    scores[0]--;
                }
            }
            else if (tmpTeam == teams[1])
            {
                if (scores[1] != 0)
                {
                    scores[1]--;
                }
            }
            tmpTeam.FindPlayer(player.Num.ToString()).undoGoal();
            if (!this.UpdateToDB().Result)
            {
                if (tmpTeam == teams[0])
                {
                    scores[0]++;
                }
                else if (tmpTeam == teams[1])
                {
                    scores[1]++;
                }
                tmpTeam.FindPlayer(player.Num.ToString()).setGoal();
            }
            return true;  
        }

        public void declareVictory(Team team)
        {
            Team winningTeam = teams.Where(el => el == team).First();
            if (winningTeam == null || ongoing == false)
                return;

            winner = winningTeam;
            winningTeam.registerWin();
            Team loserTeam = teams.Where(el => el != team).First();
            loserTeam.registerLoss();
        }

        public void declareVictoryFilip(Competition competition)
        {
            Team winningTeam = null;
            Team loser = null;

            if (scores[0] > scores[1])
            {
                winningTeam = teams[0];
                loser = teams[1];
            }
            else
            {
                winningTeam = teams[1];
                loser = teams[0];
            }
            if (String.Compare(level, "group") == 0 && scores[0] == scores[1])
            { 
                registerDraw();

                List<TeamStatistics> tmpList = competition.TeamStatistics;
                TeamStatistics tsScores1 = tmpList[tmpList.IndexOf(tmpList.Where((t) => t.ClubStat.ClubName == this.Teams[0].ClubName).FirstOrDefault())];
                TeamStatistics tsScores2 = tmpList[tmpList.IndexOf(tmpList.Where((t) => t.ClubStat.ClubName == this.Teams[1].ClubName).FirstOrDefault())];

                tsScores1.Draws++;
                if (!tsScores1.SaveToDB().Result)
                {
                    tsScores1.Draws--;
                }

                tsScores2.Draws++;
                if (!tsScores2.SaveToDB().Result)
                {
                    tsScores2.Draws--;
                }
                //winner = winningTeam;
       
            } 
            else if(String.Compare(level, "group") == 0 && scores[0] != scores[1])
            {
                List<TeamStatistics> tmpList = competition.TeamStatistics;
                TeamStatistics tsScores1 = tmpList[tmpList.IndexOf(tmpList.Where((t) => t.ClubStat.ClubName == winningTeam.ClubName).FirstOrDefault())];
                TeamStatistics tsScores2 = tmpList[tmpList.IndexOf(tmpList.Where((t) => t.ClubStat.ClubName == loser.ClubName).FirstOrDefault())];
                winningTeam.registerWin();
                loser.registerLoss();

                tsScores1.Wins++;
                if (!tsScores1.SaveToDB().Result)
                {
                    tsScores1.Wins--;
                }

                tsScores2.Loses++;
                if (!tsScores2.SaveToDB().Result)
                {
                    tsScores2.Loses--;
                }
            }
            else if(String.Compare(Level, "draw") == 0)
            {
                List<TeamStatistics> tmpList = competition.TeamStatistics;
                TeamStatistics tsScores1 = tmpList[tmpList.IndexOf(tmpList.Where((t) => t.ClubStat.ClubName == winningTeam.ClubName).FirstOrDefault())];
                TeamStatistics tsScores2 = tmpList[tmpList.IndexOf(tmpList.Where((t) => t.ClubStat.ClubName == loser.ClubName).FirstOrDefault())];
                winningTeam.registerWin();
                loser.registerLoss();

                tsScores1.Wins++;
                if (!tsScores1.SaveToDB().Result)
                {
                    tsScores1.Wins--;
                }

                tsScores2.Loses++;
                if (!tsScores2.SaveToDB().Result)
                {
                    tsScores2.Loses--;
                }
            }
            //else if(winningTeam == null && String.Compare(level, "group") != 0)
            //{
            //    MessageBox.Show("Mec u kup sistemu mora imati pobednika!");
            //    return;
            //}
            //    if (winningTeam == null || ongoing == false)
            //    return;

            winner = winningTeam; //AKO JE NERESENO, OVDE SVAKAKO NEKO MORA DA BUDE POBEDNIK
            ongoing = false;

        }

        public void registerDraw()
        {
            if (ongoing == false)
                return;

            //winner = null;
            teams[0].registerDraw();
            teams[1].registerDraw();
            ongoing = false;
        }

        #endregion

        #region Properties

        public Match RightChild
        {
            get { return rightChild; }
            set { rightChild = value; }
        }

        public Match LeftChild
        {
            get { return leftChild; }
            set { leftChild = value; }
        }

        public string SpecificNumber
        {
            get { return specificNumber; }
            set { specificNumber = value; }
        }
        public bool isOngoing
        {
            get { return ongoing; }
            set { ongoing = value; }
        }

        public string Level
        {
            get { return level; }
            set { level = value; }
        }

        public Team Winner
        {
            get { return winner; }
            set { this.winner = value; }
        }

        public DateTime Date
        {
            get { return date; }

            set { date = value; }
        }

        public Referee Referee
        {
            get { return referee; }
            set { referee = value; }
        }

        public Team[] Teams { get { return teams; } set { this.teams = value; } }
        public int[] Scores
        {
            get { return scores; }
            set { this.scores = value; }
        }

        public int IDmatch { get => Idmatch; set => Idmatch = value; }

        #endregion

        #region DBMethods
        public async Task<bool> SaveToDB()
        {
            string link = DBLinks.MatchPostLink;
            MatchModel mm = new MatchModel(this);

            string json = JsonSerializer.Serialize(mm);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            Console.WriteLine(data.Headers);

            var url = link;

            HttpClientHandler handler = new HttpClientHandler();

            var client = new HttpClient(handler);

            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            var res = await client.PostAsync(url, data).ConfigureAwait(false);

            //string result = res.Content.ReadAsStringAsync().Result;
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> LoadFromDB()
        {
            string link = DBLinks.MatchGetLink;
            HttpClientHandler handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };


            HttpClient client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, link);
            req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage msg = await client.GetAsync(link);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var s = await msg.Content.ReadAsStringAsync();
            var model = JsonSerializer.Deserialize<MatchModel>(s, options);

            referee = model.Refereee;
            teams[0] = model.Club1;
            teams[1] = model.Club2;
            ongoing = model.Live;
            //parsuj level of play
            //parsuj golove lepo
            date = model.MatchDate;
            //winner = "caos";
            this.specificNumber = model.SpecificNumber;

            return msg.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateToDB()
        {
            string link = DBLinks.MatchPutLink;
            HttpClientHandler handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            var client = new HttpClient(handler);
            var mcModel = new MatchModel(this);
            var jcontent = JsonSerializer.Serialize(mcModel);
            var requestContent = new StringContent(jcontent, Encoding.UTF8, "application/json");
            var url = link;
            var response = await client.PutAsync(url, requestContent).ConfigureAwait(false); 
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> AssignClubToMatch()
        {
            string link = DBLinks.MatchAssingLink;
            HttpClientHandler handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            var client = new HttpClient(handler);
            var mcModel = new MatchModel(this);
            var jcontent = JsonSerializer.Serialize(mcModel);
            var requestContent = new StringContent(jcontent, Encoding.UTF8, "application/json");
            var url = link;
            var response = await client.PutAsync(url, requestContent).ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }
        #endregion
    }

    #region Model
    public class MatchModel
    {

        public MatchModel()
        {

        }
        public MatchModel(Match match)
        {
            IDmatch = match.IDmatch;
            Refereee = match.Referee;
            Club1 = match.Teams[0];
            Club2 = match.Teams[1];
            HomeGoals = match.Scores[0];
            AwayGoals = match.Scores[1];
            Live = match.isOngoing;
            if(match.Level != null)
                MatchPhase = match.Level.ToString();
            MatchDate = match.Date;
            Winner = match.Winner;
            SpecificNumber = match.SpecificNumber;
        }
        public Referee Refereee { get; set; }
        public Team Club1 { get; set; }
        public Team Club2 { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public bool Live { get; set; }
        public string MatchPhase { get; set; }
        public Team Winner { get; set; }
        public DateTime MatchDate { get; set; }

        public String SpecificNumber
        {
            get; set;
        }

        public int IDmatch { get; set; }
    }
    #endregion
}
