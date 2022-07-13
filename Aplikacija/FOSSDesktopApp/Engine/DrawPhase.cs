using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Engine
{
    public class DrawPhase
    {
        #region attributes
        private Match root;
        private int depth;
        List<Match> matchesInDrawPhase;
        public Competition activeCompetition;

        #endregion

        #region constructors
        public DrawPhase(Competition competition)
        {
            activeCompetition = competition;
            Root = new Match();            
            Root.Level = "draw";
            Root.Date = this.activeCompetition.StartDate;
            Depth = 0;
            MatchesInDrawPhase = new List<Match>();

        }

        public DrawPhase(int depth)
        {
            Root = new Match();
            Root.Level = "draw";
            Root.Date = this.activeCompetition.StartDate;
            this.Depth = depth;
            MatchesInDrawPhase = new List<Match>();
        }



        #endregion

        #region properties
        public Match Root { get => root; set => root = value; }
        public int Depth { get => depth; set => depth = value; }
        public List<Match> MatchesInDrawPhase { get => matchesInDrawPhase; set => matchesInDrawPhase = value; }
        #endregion

        #region methods

        public async void loadFromDB(string link)
        {
            List<Match> matches = new List<Match>();

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
            var r = JsonSerializer.Deserialize<List<MatchModel>>(s, options);

            foreach(var match in r)
            {
                matches.Add(ConvertModelToMatch(match));
            }

            foreach(var m in matches)
                if(m.Level == "draw")
                     MatchesInDrawPhase.Add(m);

        }

        private Match ConvertModelToMatch(MatchModel model)
        {
            var match = new Match();
            match.Referee = model.Refereee;
            match.Teams[0] = model.Club1;
            match.Teams[1] = model.Club2;
            match.isOngoing = model.Live;
            match.Date = model.MatchDate;
            match.SpecificNumber = model.SpecificNumber;

            return match;
        }

        public void GenerateTree(List<Match> matches)
        {
            depth = Convert.ToInt32(Math.Round(Math.Log(matches.Count + 1, 2),MidpointRounding.AwayFromZero));

            root.SpecificNumber = "1";
            CreateEmptyTree(1, root);

            foreach(var match in matches)
            {
                string[] s = match.SpecificNumber.Split('.');

                this.root.InputMatchInPosition(match, s);
            }
        }

        public void StartDrawPhase(List<Team> teams)
        {
            this.FindDepth(teams);
            this.MatchesInDrawPhase.Add(root);
            this.CreateEmptyTree(0, this.Root);
            this.InputLeaves(teams);
        }

        private void FindDepth(List<Team> teams)
        {
            //int index = 0;
            int teamsCount = teams.Count;
            int tmpDepth = 0;
            while(teamsCount != 1)
            {
                teamsCount /= 2;
                tmpDepth++;
            }
            tmpDepth--;
            this.depth = tmpDepth;
        }

        private void CreateEmptyTree(int currDenpth, Match currNode)
        {
            if (currDenpth >= depth)
                return;

            if (currNode.LeftChild == null)
            {
                currNode.LeftChild = new Match();
                currNode.LeftChild.Date = this.activeCompetition.StartDate;
                currNode.LeftChild.Level = "draw";
                this.MatchesInDrawPhase.Add(currNode.LeftChild);
                currNode.LeftChild.SpecificNumber = currNode.SpecificNumber + ".1";
            }

            if (currNode.RightChild == null)
            {
                currNode.RightChild = new Match();
                currNode.RightChild.Level = "draw";
                currNode.RightChild.Date = this.activeCompetition.StartDate;
                this.MatchesInDrawPhase.Add(currNode.RightChild);
                currNode.RightChild.SpecificNumber = currNode.SpecificNumber + ".2";
            }

            CreateEmptyTree(currDenpth + 1, currNode.LeftChild);

            CreateEmptyTree(currDenpth + 1, currNode.RightChild);
        }


        public void MoveUpWinner(Match root, Match match, Team Winner)
        {
            // Ako je cvor list ili je pun znaci ne idemo dalje, idemo nazad
            //Nema mirkofon ovde
            if (root.Teams[0] != null && root.Teams[1] != null)
                //  if (root.Teams[0].ClubName == match.Teams[0].ClubName && root.Teams[1].ClubName == match.Teams[1].ClubName && root.SpecificNumber == match.SpecificNumber)
                return;

            //Ako je bar jedan od child cvorova ima u teams[] null, znaci idemo na sledecu rekurziju, jer taj mec jos nije poceo
            // Da, mec, ako nisu null, proverava se da li je mec koji trazimo dole
            if (root.LeftChild.Teams[0] != null && root.RightChild.Teams[0] != null && root.LeftChild.Teams[1] != null && root.RightChild.Teams[1] != null)
                if (root.LeftChild.Teams[0].ClubName == match.Teams[0].ClubName && root.LeftChild.Teams[1].ClubName == match.Teams[1].ClubName && root.LeftChild.SpecificNumber == match.SpecificNumber)
                {
                    // nasli smo winnera, propagiramo ga gore
                    if (root.Teams[0] == null)
                    {
                        root.Teams[0] = Winner;
                        root.AssignClubToMatch();

                    }
                    else
                    {
                        root.Teams[1] = Winner;
                        root.AssignClubToMatch();
                    }
                    return;
                }
                else if (root.RightChild.Teams[0].ClubName == match.Teams[0].ClubName && root.RightChild.Teams[1].ClubName == match.Teams[1].ClubName && root.RightChild.SpecificNumber == match.SpecificNumber)
                {
                    if (root.Teams[0] == null)
                    {
                        root.Teams[0] = Winner;
                        root.AssignClubToMatch();
                    }
                    else
                    {
                        root.Teams[1] = Winner;
                        root.AssignClubToMatch();
                    }
                    return;
                }
            // rekurzija
            MoveUpWinner(root.LeftChild, match, Winner);
            MoveUpWinner(root.RightChild, match, Winner);
        }


        public void InputLeaves(List<Team> teams)
        {
            Random rnd = new Random();
            Team[] teamovi = teams.OrderBy(x => rnd.Next()).ToArray();

            foreach(var team in teamovi)
            {
                AddToLeavesFilip(root, team);
            }
            MessageBox.Show("Zavrsen upis!");

        }

        private void AddToLeaves(Match current, Team team)
        {
            current = root;

            if (current.LeftChild == null && current.RightChild == null)
            {
                if (root.Teams[0] == null)
                {
                    root.Teams[0] = team;
                }
                else
                {
                    root.Teams[1] = team;
                }
                return;
            }

            AddToLeaves(current.LeftChild, team);
            AddToLeaves(current.RightChild, team);
        }

        private bool AddToLeavesFilip(Match current, Team team)
        {
            //current = root;

            if (current.LeftChild == null && current.RightChild == null)
            {
                if (current.Teams[0] == null)
                {
                    current.Teams[0] = team;
                    return true;
                }
                else if(current.Teams[1] == null)
                {
                    current.Teams[1] = team;
                    return true;
                }
                return false;
            }

            if (!AddToLeavesFilip(current.LeftChild, team))
                if (!AddToLeavesFilip(current.RightChild, team))
                    return false;
            return true;
        }
        #endregion
    }
}
