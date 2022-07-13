using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Engine
{
    public class TeamList
    {

        List<Team> teams;

        public TeamList()
        {
            teams = new List<Team>();
        }

        public void addTeam(Team team)
        {
            teams.Add(team);
        }

        public void removeTeam(Team team)
        {
            teams.Remove(team);
        }

        public bool UpdateTeam(Team oldTeam, Team newTeam)
        {
            Team tmp = null;
            tmp = findByName(oldTeam.ClubName);
            if (tmp != null)
            {
                tmp.ClubName = newTeam.ClubName;
                tmp.Trainer = newTeam.Trainer;
                tmp.Players = newTeam.Players;
                return true;
            }
            else
                return false;
        }

        public Team findByName(string name)
        {
            if(this.teams.Count != 0)
                return teams.Where(el => el.ClubName == name).FirstOrDefault();
            return null;
        }

        public Team returnByIndex(int index)
        {
            return this.teams.ElementAt(index);
        }

        public int getNumberOfTeams()
        {
            return this.teams.Count;
        }

        public Team this[int index]
        {
            get { return teams[index]; }
            set { teams[index] = value; }
        }

        public async Task<bool> LoadFromDBbb()
        {
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

                string link = DBLinks.teamListGetLink;
                HttpClient client = new HttpClient(handler);
                HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, link);
                req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var res = await client.GetAsync(link).ConfigureAwait(false);

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var s = await res.Content.ReadAsStringAsync();
                var model = JsonSerializer.Deserialize<List<TeamModel>>(s, options);

                foreach (TeamModel tm in model) {
                    this.teams.Add(new Team(tm.IDclub, tm.ClubName,tm.Players,tm.Capitain, tm.Trainer));
                }
                //public Team(string name, Player[] players, Player capitain, Trainer trainer)

                return res.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error with DB communication: " + e.Message);
                return false;
            }
        }



        //public async Task<bool> SaveToDB()
        //{
        //    try
        //    {
        //        var link;
        //        TeamList am = this;

        //        string json = JsonSerializer.Serialize(am);

        //        var data = new StringContent(json, Encoding.UTF8, "application/json");

        //        Console.WriteLine(data.Headers);

        //        var url = link;

        //        HttpClientHandler handler = new HttpClientHandler();

        //        var client = new HttpClient(handler);

        //        handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

        //        var res = await client.PostAsync(url, data);
        //        return res.IsSuccessStatusCode;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("There was an error:" + e.Message);
        //    }
        //    return false;
        //}


    }
}
