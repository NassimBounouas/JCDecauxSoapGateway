﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JCDecauxSoapGateway
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class GatewayService : SoapGateway
    {
        int value = 0;
        private static ServiceConfiguration config = null;
        private GatewayService(int value)
        {
            value = 5;
        }

        public GatewayService()
        {
            if (config == null)
            {
                GatewayService.config = new ServiceConfiguration("config.json");
            }
        }

        public string GetStations(string city)
        {
            return value + " Function not implemented";
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}