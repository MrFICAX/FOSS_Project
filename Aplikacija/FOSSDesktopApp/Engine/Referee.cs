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

namespace FOSSDesktopApp.Engine
{
    public class Referee : Participaint, IDataBaseCommunication
    {

        private int quality;

        public Referee()
            :base()
        { }

        public Referee(string name, string surname, int quality)
            :base(name, surname)
        {
            this.quality = quality;
        }

        public int Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        public async Task<bool> SaveToDB()
        {
            try
            {
                string link = DBLinks.RefereePostLink;
                RefereeModel refe = new RefereeModel(this);

                string json = JsonSerializer.Serialize(refe);

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
            catch (Exception)
            {
                return await Task.FromResult(false); //OVAJ TRY CATCH SAM PROBAO DA DODAM - NIJE HTELO JER ZALUTA NEGDE OVAJ PostAsync jer nemam bazu - Filip
            }
        }

        public async Task<bool>  LoadFromDB()
        {
            string link = DBLinks.RefereeGetLink;
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
            var model = JsonSerializer.Deserialize<RefereeModel>(s, options);

            base.PersonName = model.PersonName;
            base.Surname = model.Surname;
            quality = model.Quality;
            return msg.IsSuccessStatusCode;
        }
    }

    class RefereeModel
    {

        public RefereeModel()
        {

        }

        public RefereeModel(Referee refe)
        {
            PersonName = refe.PersonName;
            Surname = refe.Surname;
            Quality = refe.Quality;
            Ages = 0;
            BornDate = new DateTime();
        }
        public string PersonName { get; set; }
        public string Surname { get; set; }

        public DateTime BornDate { get; set; }

        public int Ages { get; set; }
        
        public int Quality { get; set; }
    }

}
