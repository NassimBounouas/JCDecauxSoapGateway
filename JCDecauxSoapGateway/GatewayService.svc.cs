using JCDecauxSoapGateway.APIHandler;
using System;
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
    public class GatewayService : ISoapGateway
    {
        private static ServiceConfiguration config = null;
        private static DataCache cache = null;

        public GatewayService()
        {
            if (config == null)
            {
                GatewayService.config = new ServiceConfiguration("config.json");
            }

            if (cache == null)
            {
                GatewayService.cache = new DataCache(GatewayService.config);
                //List<Contract> contracts = cache.getContracts();
            }
        }

        public Contract[] GetContracts()
        {
            Contract[] contracts = GatewayService.cache.GetContracts();
            //System.Diagnostics.Debug.WriteLine("IN GS " + contracts);
            return contracts;
        }

        public Station GetStationInfo(Station station)
        {
            return GatewayService.cache.GetStationInfo(station);
        }

        public Station[] GetStations(Contract contract)
        {
            return GatewayService.cache.GetStations(contract);
        }
    }
}
