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
    public class RefereeList : IDataBaseCommunication
    {
        #region attributes

        private List<Referee> refereeList;

        #endregion




        #region contructors
            
        public RefereeList()
        {
            refereeList = new List<Referee>();
        }

        public RefereeList(RefereeList org)
        {
            this.refereeList = org.refereeList;
        }

        #endregion

        #region methods

        public void Add(Referee referee)
        {
                refereeList.Add(referee);
        }

        public void Remove(Referee referee)
        {
            refereeList.Remove(referee);
        }

        public Referee FindByIndex(int index)
        {
            return refereeList[index];
        }
        /*
        public Referee findByName(string name)
        {
            if (this.refereeList.Count != 0)
                return refereeList.Where(el => el.Name == name ).FirstOrDefault();
            return null;
        }
        */

        #endregion

        #region properties

        public Referee this[int index]
        {
            get { return refereeList[index]; }
            set { refereeList[index] = value; }
        }

        public List<Referee> Referees
        {
            get { return this.refereeList; }
        }
        #endregion


        #region DBMethods
        //public async Task<bool> LoadFromDBb()
        public async Task<bool> LoadFromDB()
        {
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                string link = DBLinks.RefereeListGetLink;

                HttpClient client = new HttpClient(handler);
                HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, link);
                req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage msg = await client.GetAsync(link).ConfigureAwait(false);

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var s = await msg.Content.ReadAsStringAsync();
                var model = JsonSerializer.Deserialize<List<Referee>>(s, options); //NE DESERIJALIZUJE SE PREZIME SUDIJE

                List<Referee> tmpList = new List<Referee>();
                foreach (Referee r in model)
                    tmpList.Add(r);
                this.refereeList = tmpList;
                return true;


                /*
                var model = JsonSerializer.Deserialize<RefereeList>(s, options);
                foreach (RefereeModel tm in model)
                {
                    this.refereeList.Add(new Referee(tm.PersonName, tm.Surname, tm.Quality));
                }

                return msg.IsSuccessStatusCode;
                */
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error with DB communication: " + e.Message);
                return false;
            }
        }

        public Task<bool> SaveToDB()
        {
            throw new NotImplementedException();
        }


        //public async Task<bool> SaveToDB()
        //{
        //    try
        //    {
        //        RefereeList am = new RefereeList(this);

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

        #endregion

    }
}
