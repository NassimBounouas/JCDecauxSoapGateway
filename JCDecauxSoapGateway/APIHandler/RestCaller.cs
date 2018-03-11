using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace JCDecauxSoapGateway.APIHandler
{
    public class RestCaller
    {
        private String apiKey;

        public RestCaller(ServiceConfiguration config)
        {
            this.apiKey = config.getApiKey();
        }

        public List<Contract> GetContracts()
        {
            WebRequest request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/contracts?&apiKey=" + this.apiKey);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            List<Contract> contractList = JsonConvert.DeserializeObject<List<Contract>>(responseFromServer);
            return contractList;
        }

        public List<Station> GetStations(Contract contract)
        {
            WebRequest request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/stations?contract=" + contract.name + "&apiKey=" + this.apiKey);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Station>>(responseFromServer);
        }
    }
}