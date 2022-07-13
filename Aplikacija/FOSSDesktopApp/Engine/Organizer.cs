using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using System.Text.Encodings;
using System.Security.Cryptography;
using System.Net.Http.Json;
using System.Net.Http.Headers;

namespace FOSSDesktopApp.Engine
{
    public class Organizer : Participaint, IDataBaseCommunication
    {
        private string username;
        private string password;
        private CompetitionList events;
        private List<Administrator> adminList;

        public Organizer(string username, string pass)
            : base()
        {
            var sha1nc = new SHA1CryptoServiceProvider();
            this.username = username;
            password = Convert.ToBase64String(sha1nc.ComputeHash(Encoding.ASCII.GetBytes(pass)));
            events = new CompetitionList();
            adminList = new List<Administrator>();
        }

        public Organizer(string name, string surname, string username, string pass)
            : base(name, surname)
        {
            var sha1nc = new SHA1CryptoServiceProvider();
            this.username = username;
            password = Convert.ToBase64String(sha1nc.ComputeHash(Encoding.ASCII.GetBytes(pass)));
            events = new CompetitionList();
            adminList = new List<Administrator>();
        }

        public Organizer()
        {
        }

        public string Username
        {
            get { return username; }
        }

        public string Password
        {
            get { return password; }
        }

        public CompetitionList Events
        {
            get { return this.events; }
            set { this.events = value; }
        }

        public List<Administrator> AdminList { get { return adminList; } }
		
        public Administrator FindAdmin(string administratorName)
        {
            if (this.AdminList.Count != 0)
                return AdminList.Where(el => el.PersonName == administratorName).FirstOrDefault();
            return null;
        }


		public void AddCompetition(Competition newCompetition) //VEKI OVO SAM DODAO
        {
            Events.addEvent(newCompetition);
		}		

        public async Task<bool> SaveToDB()
        {
            try
            {
                string link = DBLinks.OrganizerPostLink;
                OrganizerModel om = new OrganizerModel(this);

                string json = JsonSerializer.Serialize(om);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                Console.WriteLine(data.Headers);

                var url = link;

                HttpClientHandler handler = new HttpClientHandler();

                var client = new HttpClient(handler);

                handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

                var res = await client.PostAsync(url, data).ConfigureAwait(false); 
                string result = res.Content.ReadAsStringAsync().Result;
                return res.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error: " + e.Message);
            }
                return false;
        }

        public async Task<bool> LoadFromDBb()
        {
            try
            {
                string link = DBLinks.OrganizerGetLink + this.username;
                HttpClientHandler handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };


                HttpClient client = new HttpClient(handler);
                HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, link);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var res = await client.GetAsync(link).ConfigureAwait(false);

                //System.Threading.Thread.Sleep(5000);

                Console.WriteLine(res.ToString());

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var s = await res.Content.ReadAsStringAsync();
                var model = JsonSerializer.Deserialize<OrganizerModel>(s, options);

                //OrganizerModel model = (OrganizerModel)await msg.Content.ReadFromJsonAsync<OrganizerModel>();

                base.PersonName = model.PersonName;
                base.Surname = model.Surname;
                username = model.Username;
                password = model.Pass;
                if (model.TournirOrganised == null)
                {
                    events = new CompetitionList();
                }
                else {
                    foreach (CompetitionModel comp in model.TournirOrganised)
                    {
                        this.Events.EventList.Add(new Competition(comp.TournirName, comp.City, comp.TournirDate, comp.TournirOrganisator, comp.Clubs, comp.TMatches, comp.Form));
                    }
                }
                if (model.AdminsCreated == null)
                {
                    this.adminList = new List<Administrator>();
                }
                else
                {
                    foreach (AdministratorModel am in model.AdminsCreated) {
                        Administrator tmpAdministrator = new Administrator(am.EnterKey, am.AdminName, am.AdminSurname, null, null);
                        foreach(CompetitionModel comp in am.Tournirs)
                        {
                            tmpAdministrator.Competitions.EventList.Add(new Competition(comp.TournirName, comp.City, comp.TournirDate, comp.TournirOrganisator, comp.Form));
                        }
                        
                        //tmpAdministrator.Competitions.EventList = am.Tournirs;
                        adminList.Add(tmpAdministrator);
                    }
                    //adminList = model.AdminsCreated; //spasen si veki
                }

                string result = res.Content.ReadAsStringAsync().Result;
                return res.IsSuccessStatusCode;

            }
            catch(Exception e)
            {
                this.username = "";
                this.password = "";
                Console.WriteLine("There was an error in communication with the database: " + e.Message);
                this.password = (new Random().Next(100000, 50000000)).ToString();
                return false;
            }
        }

        public bool Login(string user, string pass)
        {
            var sha1nc = new SHA1CryptoServiceProvider();
            pass = Convert.ToBase64String(sha1nc.ComputeHash(Encoding.ASCII.GetBytes(pass)));

            if (Username == user && Password == pass)
                return true;
            else return false;
        }

        public Task<bool> LoadFromDB()
        {
            throw new NotImplementedException();
        }
    }

    class OrganizerModel
    {
        public OrganizerModel()
        {
            AdminsCreated = new List<AdministratorModel>();
            TournirOrganised=new List<CompetitionModel>();
        }
        public OrganizerModel(Organizer org)
        {
            Username = org.Username;
            Pass = org.Password;
            PersonName = org.PersonName;
            Surname = org.Surname;
            //TournirOrganised = org.Events.EventList;
            foreach (Competition comp in org.Events.EventList)
            {
                TournirOrganised.Add(new CompetitionModel(comp));
            }
            AdminsCreated = new List<AdministratorModel>();
            foreach (Administrator am in org.AdminList) {
                AdminsCreated.Add(new AdministratorModel(am));
            }
            if (AdminsCreated == null) {
                AdminsCreated = new List<AdministratorModel>();
            }
        }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string PersonName { get; set; }
        public string Surname { get; set; }
        public string BornDate { get; set; }

        //public CompetitionList competitions { get; set; }

        public List<CompetitionModel> TournirOrganised { get; set; }

        public List<AdministratorModel> AdminsCreated { get; set; }
    }

}
