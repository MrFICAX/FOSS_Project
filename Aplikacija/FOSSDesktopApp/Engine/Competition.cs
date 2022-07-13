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
    public class Competition : IDataBaseCommunication
    {
        #region Attributes

        string name;
        string location;
        Organizer org;

        DateTime startDate;
        List<Match> matches;
        List<Team> teams;
        private List<TeamStatistics> teamStatistics;
        private List<PlayerStatistics> playerStatistics;
        string form; // group, comb, draw

        EventGroupPhase groupPhase;
        DrawPhase drawPhase;

        string winner;
        bool ongoing;
        Match currentMatch;
        int winnerPerGroup;
        int numOfTeamsPerGroup;

        #endregion

        #region Constructors
        public Competition(string name, string location, DateTime date, Organizer o, string f)
        {
            this.name = name;
            this.location = location;
            startDate = date;
            ongoing = false;
            currentMatch = null;
            matches = new List<Match>();
            teams = new List<Team>();
            winner = null;
            drawPhase = new DrawPhase(this);
            Org = o;
            TeamStatistics = new List<TeamStatistics>();
            playerStatistics = new List<PlayerStatistics>();
            Form = f;
        }

        public Competition(string name, string location, DateTime date, Organizer o,List<Team> teams, string f)
        {
            this.name = name;
            this.location = location;
            startDate = date;
            ongoing = false;
            currentMatch = null;
            matches = new List<Match>();
            this.teams = new List<Team>();
            //teams = lista;//.ToList();
            Form = f;

            foreach(Team t in teams)
            {
                Team tmpTeam = new Team(t.IDclub, t.ClubName, t.Players, t.Capitain, t.Trainer);
                this.teams.Add(tmpTeam);
            }
            winner = null;
            drawPhase = new DrawPhase(this);
            Org = o;
            TeamStatistics = new List<TeamStatistics>();
            playerStatistics = new List<PlayerStatistics>();
        }

        public Competition(string name, string location, DateTime date, Organizer o, List<Team> teams, List<MatchModel> matches, string f)
        {
            this.name = name;
            this.location = location;
            startDate = date;
            ongoing = false;
            currentMatch = null;
            this.matches = new List<Match>();
            if(matches != null)
                foreach (MatchModel m in matches)
                {
                    Match tmpMatch = new Match(m.Club1, m.Club2, m.Refereee, m.MatchDate, m.MatchPhase, m.SpecificNumber);
                    this.matches.Add(tmpMatch);
                }

            this.teams = new List<Team>();
            //teams = lista;//.ToList();
            Form = f;
            if(teams != null)
                foreach (Team t in teams)
                {
                    Team tmpTeam = new Team(t.IDclub, t.ClubName, t.Players, t.Capitain, t.Trainer);
                    this.teams.Add(tmpTeam);
                }
            winner = null;
            drawPhase = new DrawPhase(this);
            Org = o;
            TeamStatistics = new List<TeamStatistics>();
            playerStatistics = new List<PlayerStatistics>();
        }

        public Competition(string name, string location, DateTime date, List<Team> teams, List<Match> matches, List<TeamStatistics> teamStatistics, List<PlayerStatistics> playerStatistics)
        {
            this.name = name;
            this.location = location;
            startDate = date;
            ongoing = false;
            currentMatch = null;
            this.matches = new List<Match>();
            this.matches = matches; //OVDE CE VEROVATNO MORATI KROZ FOREACH PETLJU
           
            this.teams = new List<Team>();
            //this.teams = teams;//.ToList();
            foreach (Team t in teams)
            {
                Team tmpTeam = new Team(t.IDclub, t.ClubName, t.Players, t.Capitain, t.Trainer);
                this.teams.Add(tmpTeam);
            }

            winner = null;
            drawPhase = new DrawPhase(this);
            this.teamStatistics = new List<TeamStatistics>(); //OVDE CE VEROVATNO MORATI KROZ FOREACH PETLJU
            this.playerStatistics = new List<PlayerStatistics>(); //OVDE CE VEROVATNO MORATI KROZ FOREACH PETLJU
        }

        public Competition(string name, string location, DateTime date, List<Team> teams, List<MatchModel> matches, List<TeamStatistics> teamStatistics, List<PlayerStatistics> playerStatistics)
        {
            this.name = name;
            this.location = location;
            startDate = date;
            ongoing = false;
            currentMatch = null;
            this.matches = new List<Match>();
            // this.matches = matches; //OVDE CE VEROVATNO MORATI KROZ FOREACH PETLJU
            if(matches != null)
            {

                foreach (MatchModel matchModel in matches)
                {
                    Match tmpMatch = new Match( matchModel.IDmatch, matchModel.Club1, matchModel.Club2, matchModel.Winner, matchModel.HomeGoals, matchModel.AwayGoals, matchModel.Refereee, matchModel.MatchDate, matchModel.MatchPhase, matchModel.SpecificNumber, matchModel.Live);
                    this.matches.Add(tmpMatch);
                }
            }

            this.teams = new List<Team>();
            //this.teams = teams;//.ToList();
            if(teams != null)
            {
                foreach (Team t in teams)
                {
                    Team tmpTeam = new Team(t.IDclub, t.ClubName, t.Players, t.Capitain, t.Trainer);
                    this.teams.Add(tmpTeam);
                }
            }

            winner = null;
            drawPhase = new DrawPhase(this);
            this.teamStatistics = new List<TeamStatistics>(); //OVDE CE VEROVATNO MORATI KROZ FOREACH PETLJU
            this.playerStatistics = new List<PlayerStatistics>(); //OVDE CE VEROVATNO MORATI KROZ FOREACH PETLJU
            
            if(form=="group" || form == "comb")
            {
                foreach(var stat in teamStatistics)
                groupPhase.loadPointsfromStatistics(stat);
            }
        }

        public Competition()
        {
            ongoing = false;
            currentMatch = null;
            matches = new List<Match>();
            teams = new List<Team>();
            winner = null;
            drawPhase = new DrawPhase(this);
            Org = new Organizer();
            TeamStatistics = new List<TeamStatistics>();
            PlayerStatistics = new List<PlayerStatistics>();
        }
        #endregion
        #region Methods

        public bool IsGroupFinished()
        {
            List<Match> tmpList = new List<Match>();
           
            int counter = 0;
            foreach(Match m in matches)
            {
                if(m.Level == "grupa")
                {
                    tmpList.Add(m);
                   
                }


            }
            foreach(Match tmpMatch in tmpList)
            {
                if (!tmpMatch.isOngoing && tmpMatch.Referee != null)
                {
                    counter++;
                }
            }
            if(counter == tmpList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void addGoalToPlayer(Player p)
        {
            PlayerStatistics ps = playerStatistics[playerStatistics.IndexOf(playerStatistics.Where((pl) => pl.PlayerStat.Captain == p.Captain && pl.PlayerStat.PersonName == p.PersonName && pl.PlayerStat.Surname == p.Surname && pl.PlayerStat.Num == p.Num).FirstOrDefault())];
            if (ps.Goals != 100)
                ps.Goals++;
            if (!ps.SaveToDB().Result)
            {
                ps.Goals--;
            }


        }

        public void SetGoalToTeamStatistics(Team scoredGoal, Team receivedGoal)
        {
            TeamStatistics tsScores = teamStatistics[teamStatistics.IndexOf(teamStatistics.Where((t) => t.ClubStat.ClubName == scoredGoal.ClubName).FirstOrDefault())];
            tsScores.GoalsDifference++;
            if (!tsScores.SaveToDB().Result)
            {
                tsScores.GoalsDifference--;
            }


            TeamStatistics tsReceived = teamStatistics[teamStatistics.IndexOf(teamStatistics.Where((t) => t.ClubStat.ClubName == receivedGoal.ClubName).FirstOrDefault())];
            tsReceived.GoalsDifference--;
            if (!tsReceived.SaveToDB().Result)
            {
                tsReceived.GoalsDifference++;
            }
        }

        public void UndoGoalToTeamStatistics(Team UndoscoredGoal, Team UndoreceivedGoal)
        {
            TeamStatistics tsScores = teamStatistics[teamStatistics.IndexOf(teamStatistics.Where((t) => t.ClubStat.ClubName == UndoscoredGoal.ClubName).FirstOrDefault())];
            tsScores.GoalsDifference--;
            if (!tsScores.SaveToDB().Result)
            {
                tsScores.GoalsDifference++;
            }


            TeamStatistics tsReceived = teamStatistics[teamStatistics.IndexOf(teamStatistics.Where((t) => t.ClubStat.ClubName == UndoreceivedGoal.ClubName).FirstOrDefault())];
            tsReceived.GoalsDifference++;
            if (!tsReceived.SaveToDB().Result)
            {
                tsReceived.GoalsDifference--;
            }
        }

        public void undoGoalToPlayer(Player p)
        {
            PlayerStatistics ps = playerStatistics[playerStatistics.IndexOf(playerStatistics.Where((pl) => pl.PlayerStat.Captain == p.Captain && pl.PlayerStat.PersonName == p.PersonName && pl.PlayerStat.Surname == p.Surname && pl.PlayerStat.Num == p.Num).FirstOrDefault())];
            if (ps.Goals != 0)
            {       
                ps.Goals--;
                if (!ps.SaveToDB().Result)
                {
                    ps.Goals++;
                }
            }

        }


        public void addCardToPlayer(Player p)
        {
            PlayerStatistics ps = playerStatistics[playerStatistics.IndexOf(playerStatistics.Where((pl) => pl.PlayerStat.Captain == p.Captain && pl.PlayerStat.PersonName == p.PersonName && pl.PlayerStat.Surname == p.Surname && pl.PlayerStat.Num == p.Num).FirstOrDefault())];

            ps.Cards++;
            if (!ps.SaveToDB().Result)
            {
                ps.Cards--;
            }
        }

        public void undoCardToPlayer(Player p)
        {
            PlayerStatistics ps = playerStatistics[playerStatistics.IndexOf(playerStatistics.Where((pl) => pl.PlayerStat.Captain == p.Captain && pl.PlayerStat.PersonName == p.PersonName && pl.PlayerStat.Surname == p.Surname && pl.PlayerStat.Num == p.Num).FirstOrDefault())];
            if (ps.Cards != 0)
            {
                ps.Cards--;
                if (!ps.SaveToDB().Result)
                {
                    ps.Cards++;
                }
            }
        }

        public void AddTeam(Team team)
        {
                teams.Add(team);
            //teamStatistics.Add(new TeamStatistics(this, team));

            //    foreach (var p in team.Players)
            //        playerStatistics.Add(new PlayerStatistics(p));
            
        }

        public void RemoveTeam(Team Team)
        {
            teams.Remove(Team);
        }

        public void AddMatch(Match match)
        {
            matches.Add(match);
        }

        public void Start()
        {
            ongoing = true;
        }

        public void DeclareWinner(string winnerTeam)
        {
            winner = winnerTeam;
            ongoing = false;
            currentMatch = null;
        }

        public void startMatch(Match match)
        {
            match.start();
            currentMatch = match;
        }

        public void startDrawPhase()
        {
            form = "draw";
            this.DrawPhase.StartDrawPhase(this.teams);
            this.MatchListList = this.DrawPhase.MatchesInDrawPhase;
            if (this.InsertMatchesToDB().Result) { }



        }

        public void startGroupPhase(int numberOfGroups, int groupSize, int numOfWinnersPerGroup)
        {
            this.NumOfTeamsPerGroup = groupSize;
            this.WinnerPerGroup = numOfWinnersPerGroup;
            if (numberOfGroups == 1)
                form = "group";
            else
                form = "comb";
            groupPhase = new EventGroupPhase(groupSize, numberOfGroups, numOfWinnersPerGroup, this);

            foreach (var team in teams)
                groupPhase.AddTeam(team);

            this.matches = groupPhase.GenerateMatches();
            if (this.InsertMatchesToDB().Result) { }
        }

        public void finishMatch(Match match)
        {
            if (match.Level == "group")
            {
                bool groupPhaseDone = true;

                match.declareVictoryFilip(this);
                if (match.UpdateToDB().Result) { }
                /*if(match.Winner!=null)
                    addGroupPhasePoints(match.Winner);*/
                

                //var teamWinner = teamStatistics.Find((stat) => stat.ClubStat.ClubName == match.Winner.ClubName);
                //groupPhase.updateTeamStatistics(teamWinner);             
                //UpdateStatisticsToDB(teamStatistics.Find((s)=>s.ClubStat.ClubName == match.Winner.ClubName));
                
                foreach(var m in matches)
                {
                    if (m.isOngoing == false && m.Winner == null)
                        groupPhaseDone = false;
                }
                if(groupPhaseDone)
                {
                    var winnerTeamsGroup = FinishGroupPhase();
                    if (form == "comb")
                    {
                        drawPhase.StartDrawPhase(winnerTeamsGroup);
                        foreach (Match m in this.DrawPhase.MatchesInDrawPhase)
                            this.MatchListList.Add(m);

                        if (this.InsertMatchesToDB().Result) { }

                        
                        List<MatchModel> tmpList = new List<MatchModel>();
                        if (this.LoadMatchDraw(tmpList).Result)
                        {
                            foreach(var item in tmpList)
                            {
                                foreach(Match m in this.DrawPhase.MatchesInDrawPhase)
                                {
                                    if(m.SpecificNumber == item.SpecificNumber)
                                    {
                                        m.IDmatch = item.IDmatch;
                                    }
                                }
                            }
                        }

                    }
                    if (form == "group")
                    {
                        this.winner = winnerTeamsGroup[0].ClubName;
                        if (this.UpdateToDB().Result) { }
                    }
                }
            }
            else if(match.Level == "draw")
            {
                match.declareVictoryFilip(this);

                if (match.UpdateToDB().Result) { }
                drawPhase.MoveUpWinner(drawPhase.Root, match, match.Winner);
                foreach (Team t in match.Teams) {
                    if (match.Winner.ClubName == t.ClubName)
                    {
                        TeamStatistics tmpStatistics = teamStatistics.Find((s) => s.ClubStat.ClubName == t.ClubName);
                        tmpStatistics.Wins++;
                        if (UpdateStatisticsToDB(tmpStatistics).Result) { }
                    }
                    else {
                        TeamStatistics tmpStatistics = teamStatistics.Find((s) => s.ClubStat.ClubName == t.ClubName);
                        tmpStatistics.Loses++;
                        if (UpdateStatisticsToDB(tmpStatistics).Result) { }
                    }
                    
                     
                }
                if (match.SpecificNumber == drawPhase.Root.SpecificNumber && match.Teams[0].ClubName==drawPhase.Root.Teams[0].ClubName && match.Teams[1].ClubName == drawPhase.Root.Teams[1].ClubName)
                {
                    winner = match.Winner.ClubName;
                    if (this.UpdateToDB().Result) { }
                }
            }
        }

        private async Task<bool> UpdateToDB()
        {
            string link = DBLinks.CompetitionUpdateLink;
            CompetitionModel cm = new CompetitionModel(this);

            string json = JsonSerializer.Serialize(cm);

            Console.WriteLine(json);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            Console.WriteLine(data.Headers);

            var url = link;

            HttpClientHandler handler = new HttpClientHandler();

            var client = new HttpClient(handler);

            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            var res = await client.PutAsync(url, data).ConfigureAwait(false);
            return res.IsSuccessStatusCode;



        }

        public void addGroupPhasePoints(Team team)
        {
            groupPhase.AddPoints(team);
            var stat = teamStatistics.Find((el) => el.ClubStat.ClubName == team.ClubName);
           // teamStatistics[teamStatistics.IndexOf(stat)].Wins++;
        }

        public List<Team> FinishGroupPhase()
        {
           // foreach (var group in groupPhase.Groupes) //CEMU SLUZI OVO GROUP
           //     groupPhase.Eliminate(groupPhase.Groupes.Count); //MSM DA OVA LINIJA TREBA DA SE IZMENI

            List<Team> groupPhaseWinnerTeams = groupPhase.FinishGroupePhase();
            //drawPhase.InputLeaves(groupPhaseWinnerTeams);
            return groupPhaseWinnerTeams;
        }

        public Team FindTeam(string selectedTeam)
        {
            return teams.Find(item => item.ClubName == selectedTeam); //OVO SAM DODAO VEKI, TREBALO BI DA JE U REDU FUNKCIJA
        }

        public Match FindMatch(string selectedTeam1, string selectedTeam2)
        {
            if(String.Compare(selectedTeam1, "Prvi klub nepoznat") == 0 || String.Compare(selectedTeam2, "Drugi tim nepoznat") == 0)
            {
                MessageBox.Show("Imena timova su nepoznati!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
                Team team1 = this.FindTeam(selectedTeam1);
            Team team2 = this.FindTeam(selectedTeam2);
            //return matches.Find(item =>  item.Teams[0].ClubName == team1.ClubName && item.Teams[1].ClubName == team2.ClubName);
            Match found;
            if(team1 != null && team2 != null)
                foreach(Match tmpMatch in matches)
                {
                    if(tmpMatch.Teams[0] != null && tmpMatch.Teams[1] != null)
                    {
                        if(tmpMatch.Teams[0].ClubName == team1.ClubName && tmpMatch.Teams[1].ClubName == team2.ClubName && tmpMatch.Winner == null)
                        {
                            found = tmpMatch;
                            return found;
                        }
                    }
                }
            return null;

        }
        #endregion

        #region Properties
        public bool isOngoing
        {
            get { return ongoing; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public Match CurrentMacth
        {
            get { return currentMatch; }
        }

        public Match[] MatchList { 
            get { return matches.ToArray(); }
            //set { this.matches = value; }
        }

        public List<Match> MatchListList
        {
            get { return this.matches; }
            set { this.matches = value; }
        }

        public Team[] TeamList
        {
            get { return teams.ToArray(); }
        }
        public List<Team> TeamListList
        {
            get { return this.teams; }
        }

        public DrawPhase DrawPhase
        {
            get { return this.drawPhase; }
            set{ this.drawPhase = value; }
        }

        public string Winner 
        { 
            get { return winner; } 
        }

        public Organizer Org { get => org; set => org = value; }
        public List<PlayerStatistics> PlayerStatistics { get => playerStatistics; set => playerStatistics = value; }
        public List<TeamStatistics> TeamStatistics { get => teamStatistics; set => teamStatistics = value; }
        public string Form { get => form; set => form = value; }
        public int WinnerPerGroup { get => winnerPerGroup; set => winnerPerGroup = value; }
        public int NumOfTeamsPerGroup { get => numOfTeamsPerGroup; set => numOfTeamsPerGroup = value; }

        #endregion

        #region DBMethods

        public async Task<bool> LoadMatchDraw(List<MatchModel> list)
        {
            try
            {
                string link = DBLinks.DrawMatchesLink + this.Name;
                HttpClientHandler handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };


                HttpClient client = new HttpClient(handler);
                HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, link);
                req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage msg = await client.GetAsync(link).ConfigureAwait(false);

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var s = await msg.Content.ReadAsStringAsync();
                var model = JsonSerializer.Deserialize<List<MatchModel>>(s, options);

                foreach (var m in model)
                    list.Add(m);
                return true;
            }
            catch(Exception err)
            {
                Console.WriteLine(err);
                list = null;
                return false;
            }
        }
        public async Task<bool> SaveToDBb(Organizer tmpOrganizer)
        {
            string link = DBLinks.CompetitionPostLink + tmpOrganizer.Username;
            CompetitionModel cm = new CompetitionModel(this);

            string json = JsonSerializer.Serialize(cm);

            Console.WriteLine(json);

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
            try
            {

            
            string link = DBLinks.CompetitionGetLink + this.Name;
            HttpClientHandler handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };


            HttpClient client = new HttpClient(handler);
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, link);
            req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage msg = await client.GetAsync(link).ConfigureAwait(false);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var s = await msg.Content.ReadAsStringAsync();
            var model = JsonSerializer.Deserialize<CompetitionModel>(s, options);

            Name = model.TournirName;
            location = model.City;
            StartDate = model.TournirDate;
            Form = model.Form;
            ongoing = model.Ongoing;
                NumOfTeamsPerGroup = model.NumOfTeamsPerGroup;

                teams = new List<Team>();
                foreach(Team t in model.Clubs) {
                    teams.Add(new Team(t.IDclub, t.ClubName, t.Players, t.Capitain, t.Trainer));
                }
            matches = new List<Match>();
                winnerPerGroup = model.WinnersPerGroup;
            foreach (MatchModel matchModel in model.TMatches)
            {
                Match tmpMatch = new Match(matchModel.IDmatch, matchModel.Club1, matchModel.Club2, matchModel.Winner, matchModel.HomeGoals, matchModel.AwayGoals, matchModel.Refereee, matchModel.MatchDate, matchModel.MatchPhase, matchModel.SpecificNumber, matchModel.Live);
                matches.Add(tmpMatch);
            }
                
            foreach(var teamStat in model.ClubsStatistics)
            {
                this.teamStatistics.Add(teamStat);
            }


            foreach (var playerStat in model.PlayerStatistics)
            {
                this.playerStatistics.Add(playerStat);
            }
                this.Create(this.matches);

            winner = model.TournirWinner;
            currentMatch = model.CurrentMatch;
            org = model.TournirOrganisator;

            //for (int stat = 0; stat < TeamStatistics.Count; stat++)
            //{
            //    TeamStatistics[stat].LoadFromDB();
            //}

            return msg.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                MessageBox.Show("GRESKA SA SERVEROM!");
                return false;
            }
        }

        private void Create(List<Match> matches)
        {
            if (matches.Count == 0)
                return;

            if(this.Form == "draw" || this.Form=="comb")
            {
                var drawMatch = new List<Match>();
                foreach (var m in matches)
                    if(m.Level == "draw")
                        drawMatch.Add(m);
                this.drawPhase = new DrawPhase(this);
                this.drawPhase.GenerateTree(drawMatch);

         
            }
            if(this.Form == "group" || this.Form == "comb")
            {
                string[] pom;
                int max = 0;

                foreach (var m in this.matches)
                {
                    if (m.Level == "group")
                    {
                        pom = m.SpecificNumber.Split('.');
                        if (Convert.ToInt32(pom[0]) > max)
                            max = Convert.ToInt32(pom[0]);
                    }
                }

                this.groupPhase = new EventGroupPhase(this.NumOfTeamsPerGroup, max, this.winnerPerGroup, this);
                foreach (var t in teams)
                {
                    this.groupPhase.AddTeam(t);
                    addGroupPhasePoints(t);
                }

             
            }
        }

        public async Task<bool> InsertMatchesToDB()
        {
            string link = DBLinks.CompetitionPutLink;
            HttpClientHandler handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            var client = new HttpClient(handler);
            var cmpModel = new CompetitionModel(this);
            var jcontent = JsonSerializer.Serialize(cmpModel);
            var requestContent = new StringContent(jcontent, Encoding.UTF8, "application/json");
            var url = link;
            var response = await client.PutAsync(url, requestContent).ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateStatisticsToDB(TeamStatistics stat)
        {
            string link = DBLinks.CompetitionStatisticsUpdate;
            HttpClientHandler handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            var client = new HttpClient(handler);
            var cmpModel = new CompetitionModel(this);
            var jcontent = JsonSerializer.Serialize(stat);
            var requestContent = new StringContent(jcontent, Encoding.UTF8, "application/json");
            var url = link;
            var response = await client.PutAsync(url, requestContent).ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> DeleteFromDB()
        {
            //    HttpClientHandler handler = new HttpClientHandler();
            //    handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            //    var client = new HttpClient(handler);

            //    var url = link;
            //var response = await client.DeleteAsync(url);
            //return response.IsSuccessStatusCode;

            string link = DBLinks.CompetitionDeleteLink;

            CompetitionModel cm = new CompetitionModel(this);

            string json = JsonSerializer.Serialize(cm);

            Console.WriteLine(json);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            Console.WriteLine(data.Headers);

            var url = link;

            HttpClientHandler handler = new HttpClientHandler();

            var client = new HttpClient(handler);

            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            var res = await client.PostAsync(url, data);
            return res.IsSuccessStatusCode;
        }

        public Task<bool> SaveToDB()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    #region Model
    class CompetitionModel
    {

        public CompetitionModel()
        {
            TMatches = new List<MatchModel>();
            Clubs = new List<Team>();
            ClubsStatistics = new List<TeamStatistics>();
            PlayerStatistics = new List<PlayerStatistics>();

        }
        public CompetitionModel(Competition comp)
        {
            WinnersPerGroup = comp.WinnerPerGroup;
            NumOfTeamsPerGroup = comp.NumOfTeamsPerGroup;
            TournirName = comp.Name;
            City = comp.Location;
            Form = comp.Form;
            TournirDate = comp.StartDate;
            Ongoing = comp.isOngoing;
            TournirWinner = comp.Winner;
            CurrentMatch = comp.CurrentMacth;
            //TMatches = comp.MatchList;
            TMatches = new List<MatchModel>();
            foreach (Match tmpModel in comp.MatchList)
            {
                MatchModel tmpMatchModel = new MatchModel(tmpModel);
                TMatches.Add(tmpMatchModel);
            }

            Clubs = new List<Team>();
            //Clubs = comp.TeamListList;
            foreach(Team tmpTeam in comp.TeamListList)
            {
                Clubs.Add(tmpTeam);
            }
            //TournirOrganisator = comp.Org;
            this.ClubsStatistics = new List<TeamStatistics>();
            foreach (var teamStat in comp.TeamStatistics)
            {
                this.ClubsStatistics.Add(teamStat);
            }
            this.PlayerStatistics = new List<PlayerStatistics>();
            foreach(var playerStat in comp.PlayerStatistics)
            {
                this.PlayerStatistics.Add(playerStat);
            }
        }

        public int IDTournir { get; set; }
        public string TournirName { get; set; }
        public string City { get; set; }
        public string Form { get; set; }
        public DateTime TournirDate { get; set; }
        public Organizer TournirOrganisator { get; set; }
        public bool Ongoing { get; set; }
        public string TournirWinner { get; set; }
        public Match CurrentMatch { get; set; }
        public List<MatchModel> TMatches { get; set; }
        public List<Team> Clubs { get; set; }
        public List<PlayerStatistics> PlayerStatistics { get; set; }
        public List<TeamStatistics> ClubsStatistics { get; set; }

        public int WinnersPerGroup { get; set; }
        public int NumOfTeamsPerGroup { get; set; }
    }
    #endregion
}
