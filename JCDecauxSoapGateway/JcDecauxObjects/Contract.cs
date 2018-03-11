using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JCDecauxSoapGateway
{
    [DataContract]
    public class Contract
    {
        [DataMember]
        public String name { get; set; }
        [DataMember]
        public String commercial_name { get; set; }
    }
}