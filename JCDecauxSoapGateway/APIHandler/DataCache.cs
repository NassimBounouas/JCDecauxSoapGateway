using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JCDecauxSoapGateway.APIHandler
{

    public class DataCache
    {
        private RestCaller caller;
        private List<Contract> contracts;

        public DataCache(ServiceConfiguration config)
        {
            this.caller = new RestCaller(config);
        }

        public Contract[] GetContracts()
        {
            this.contracts = this.caller.GetContracts();
            return this.contracts.ToArray();
        }

        public Station[] GetStations(Contract contrat)
        {
           return this.caller.GetStations(contrat).ToArray();
        }
    }
}