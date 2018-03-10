using JCDecauxSoapGateway.JcDecauxObjects;
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

        public Contract[] getContracts()
        {
            this.contracts = this.caller.getContracts();
            System.Diagnostics.Debug.WriteLine("First contract in DATACACHE " + this.contracts.Count);
            return this.contracts.ToArray();
        }
    }
}