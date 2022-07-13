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
    public class Trainer : Participaint, IDataBaseCommunication
    {

        #region Constructor
        public Trainer()
            :base () { }

        public Trainer(string name, string surname)
            :base(name, surname) { }

        #endregion

        #region DBMethods

        public async Task<bool> LoadFromDB()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            string link = null;
            HttpClient client = new HttpClient(handler);
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, link);
            req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage msg = await client.GetAsync(link);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var s = await msg.Content.ReadAsStringAsync();
            var model = JsonSerializer.Deserialize<TrainerModel>(s, options);

            base.PersonName = model.PersonName;
            base.Surname = model.Surname;
            return msg.IsSuccessStatusCode;
        }


        public async Task<bool> SaveToDB()
        {
            TrainerModel trainer = new TrainerModel(this);
            string link = "";
            string json = JsonSerializer.Serialize(trainer);

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
    class TrainerModel
    {

        public TrainerModel()
        {

        }
        public TrainerModel(Trainer trainer)
        {
            PersonName = trainer.PersonName;
            Surname = trainer.Surname;
        }

        public string PersonName
        {
            get; set;
        }

        public string Surname { get; set; }
    }
    #endregion
}
