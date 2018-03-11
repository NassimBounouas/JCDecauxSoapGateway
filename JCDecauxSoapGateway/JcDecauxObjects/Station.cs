using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JCDecauxSoapGateway
{
    [DataContract]
    public class Station
    {
        [DataMember]
        public int number { get; set; }

        [DataMember]
        public String name { get; set; }

        [DataMember]
        public String address { get; set; }

        [DataMember]
        public double lat { get; set; }

        [DataMember]
        public double lng { get; set; }

        [DataMember]
        public Boolean banking { get; set; }

        [DataMember]
        public Boolean bonus { get; set; }

        [DataMember]
        public String status { get; set; }

        [DataMember]
        public String contract_name { get; set; }

        [DataMember]
        public int bike_stands { get; set; }

        [DataMember]
        public int available_bike_stands { get; set; }

        [DataMember]
        public int available_bikes { get; set; }

        [DataMember]
        public Int64 last_update { get; set; }
    }
}