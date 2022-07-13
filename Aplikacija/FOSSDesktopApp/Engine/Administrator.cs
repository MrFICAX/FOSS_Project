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
using System.Windows.Forms;

namespace FOSSDesktopApp.Engine
{
    public class Administrator : Participaint, IDataBaseCommunication
    {
        #region Attributes
        private string enterKey;
        private CompetitionList events;
        private string org;
        #endregion

        #region Constructors

        public Administrator():base() { }
        public Administrator(string ek)
            :base()
        {
            var sha1enc = new SHA1CryptoServiceProvider();
            enterKey = Convert.ToBase64String(sha1enc.ComputeHash(Encoding.ASCII.GetBytes(ek)));
            while (enterKey == null || enterKey.Contains('/'))
            {
                sha1enc = new SHA1CryptoServiceProvider();
                enterKey = Convert.ToBase64String(sha1enc.ComputeHash(Encoding.ASCII.GetBytes(enterKey)));
            }
        }

        public Administrator(string ek, string name, string surname, string o)
            :base(name, surname)
        {
            var sha1enc = new SHA1CryptoServiceProvider();
            enterKey = Convert.ToBase64String(sha1enc.ComputeHash(Encoding.ASCII.GetBytes(ek)));
            while (enterKey == null || enterKey.Contains('/'))
            {
                sha1enc = new SHA1CryptoServiceProvider();
                enterKey = Convert.ToBase64String(sha1enc.ComputeHash(Encoding.ASCII.GetBytes(enterKey)));
            }

            Events = new CompetitionList();

            org = o;
        }

        public Administrator(string ek, string name, string surname, string o, string prazno)
            : base(name, surname)
        {
            //var sha1enc = new SHA1CryptoServiceProvider();
            //enterKey = Convert.ToBase64String(sha1enc.ComputeHash(Encoding.ASCII.GetBytes(ek)));
            enterKey = ek;
            Events = new CompetitionList();

            org = o;
        }

        #endregion

        #region Properties

        public string EnterKey
        {
            get { return enterKey; }
            set {
                var sha1enc = new SHA1CryptoServiceProvider();
                enterKey = Convert.ToBase64String(sha1enc.ComputeHash(Encoding.ASCII.GetBytes(value)));
                }
        }

        public CompetitionList Competitions 
        {
            get { return Events; } 
            set { Events = value; } 
        }

        public string Org { get => org; set => org = value; }
        public CompetitionList Events { get => events; set => events = value; }

        #endregion

        #region Methods
        public bool CheckEnterKey(string ek)
        {
            var sha1enc = new SHA1CryptoServiceProvider();
            var enterKey = Convert.ToBase64String(sha1enc.ComputeHash(Encoding.ASCII.GetBytes(ek)));
            while (enterKey == null || enterKey.Contains('/'))
            {
                sha1enc = new SHA1CryptoServiceProvider();
                enterKey = Convert.ToBase64String(sha1enc.ComputeHash(Encoding.ASCII.GetBytes(enterKey)));
            }
            if (enterKey == this.enterKey)
                return true;
            else
                return false;
        }

        public async Task<bool> SaveToDB()
        {
            try
            {

                string link = DBLinks.AdminPostLink+"/"+this.Org;
                AdministratorModel am = new AdministratorModel(this);

                string json = JsonSerializer.Serialize(am);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                Console.WriteLine(data.Headers);

                var url = link;

                HttpClientHandler handler = new HttpClientHandler();

                var client = new HttpClient(handler);

                handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

                var res = await client.PostAsync(url, data).ConfigureAwait(false);
                if((int)res.StatusCode == 401)
                {
                    MessageBox.Show("ADMINISTRATOR SA OVIM ENTERKEY PODATKOM VEC POSTOJI", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);                  
                }
                return res.IsSuccessStatusCode;
            }
            catch(Exception e)
            {
                Console.WriteLine("There was an error:" + e.Message);
            }
            return false;
        }

        public async Task<bool> UpdateCompetitionListtoDB(Competition tmpCompetition)
        {
            try
            {

                string link = DBLinks.AdminAssignToCompetitionLink + tmpCompetition.Name;
                AdministratorModel am = new AdministratorModel(this);

                string json = JsonSerializer.Serialize(am);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                Console.WriteLine(data.Headers);

                var url = link;

                HttpClientHandler handler = new HttpClientHandler();

                var client = new HttpClient(handler);

                handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

                var res = await client.PutAsync(url, data).ConfigureAwait(false);
                return res.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error:" + e.Message);
            }
            return false;
        }

        public async Task<bool> UnAssignCompetitionFromDB(Competition competition)
        {
            try
            {

                string link = DBLinks.AdminUnAssignToCompetitionLink + competition.Name;
                AdministratorModel am = new AdministratorModel(this);

                string json = JsonSerializer.Serialize(am);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                Console.WriteLine(data.Headers);

                var url = link;

                HttpClientHandler handler = new HttpClientHandler();

                var client = new HttpClient(handler);

                handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

                var res = await client.PutAsync(url, data).ConfigureAwait(false);
                return res.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error:" + e.Message);
            }
            return false;
        }

        public async Task<bool> LoadFromDB()
        {
            try
            {
                string link = DBLinks.AdminGetLink + this.enterKey ;
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
                var model = JsonSerializer.Deserialize<AdministratorModel>(s, options);

                base.PersonName = model.AdminName;
                base.Surname = model.AdminSurname;
                enterKey = model.EnterKey;
                //events = new CompetitionList(model.Tournirs);
                Events = new CompetitionList();
                if(model.Tournirs!= null)
                {
                    foreach (CompetitionModel comp in model.Tournirs)
                    {
                        Events.addEvent(new Competition(comp.TournirName, comp.City, comp.TournirDate, comp.Clubs, comp.TMatches, comp.ClubsStatistics, comp.PlayerStatistics));

                      // EventList.Add(new Competition(comp.TournirName, comp.City, comp.TournirDate, comp.TournirOrganisator, comp.Clubs));
                    }
                }

                return msg.IsSuccessStatusCode;
            }
            catch(Exception e)
            {
                Console.WriteLine("There was an error with DB communication: " + e.Message);
                this.enterKey = (new Random().Next(100000, 5000000)).ToString();
                return false;
            }
        }

        public async Task<bool> DeleteFromDB()
        {
           string link = DBLinks.AdminDeleteLink;
            AdministratorModel am = new AdministratorModel(this);

            string json = JsonSerializer.Serialize(am);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            Console.WriteLine(data.Headers);

            var url = link;

            HttpClientHandler handler = new HttpClientHandler();

            var client = new HttpClient(handler);

            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            var res = await client.PostAsync(url, data).ConfigureAwait(false);
            return res.IsSuccessStatusCode;
        }

        /*
          
        public Task<bool> SaveToDB()
        {
            throw new NotImplementedException();
        }

        */

        #endregion

    }

    #region Model

    class AdministratorModel
    {
        public AdministratorModel()
        {
            Tournirs = new List<CompetitionModel>();
        }
        public AdministratorModel(Administrator admin)
        {
            AdminName = admin.PersonName;
            AdminSurname = admin.Surname;
            EnterKey = admin.EnterKey;
            //Tournirs = new List<Competition>();
            //Tournirs = admin.Competitions.EventList;
            //Tournirs = admin.Competitions.EventList;
         //   GiveAccessBy = admin.Org;
        }
        public string EnterKey { get; set; }
        public string AdminName { get; set; }
        public string AdminSurname { get; set; }
       // public string GiveAccessBy { get; set; }
        public List<CompetitionModel> Tournirs { get; set; }
    }
    #endregion
}
