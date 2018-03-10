using JCDecauxSoapGateway.JcDecauxObjects;
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

        public List<Contract> getContracts()
        {
            WebRequest request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/contracts?&apiKey=" + this.apiKey);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            //JArray contracts = JArray.Parse(responseFromServer);
            //List<Contract> contractList = new List<Contract>();
            List<Contract> contractList = JsonConvert.DeserializeObject<List<Contract>>(responseFromServer);
            /*
            foreach (JObject v in contracts.Children<JObject>())
            {
                // Auto Deserialization isn't working there
                Contract c = new Contract();
                c.name = v.GetValue("name").ToString();
                c.commercial_name = v
                
                //c.name = v.GetValue("name").ToString();

                System.Diagnostics.Debug.Write("IN CALLER " + c.name);
                contractList.Add(c);
            }*/
            return contractList;
        }
    }
}