using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace JCDecauxSoapGateway
{
    public class ServiceConfiguration
    {
        private String apiKey;

        public ServiceConfiguration(string filename)
        {
            StreamReader streader = new StreamReader(filename);
            JsonTextReader jsonReader = new JsonTextReader(streader);
            JObject config = (JObject) JToken.ReadFrom(jsonReader);
            this.apiKey = config.GetValue("key").ToString();
        }

        public String getApiKey()
        {
            return this.apiKey;
        }
    }
}