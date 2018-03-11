using System;
using System.Collections.Generic;
using System.Runtime.Caching;

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

        public Station GetStationInfo(Station station)
        {
            return this.GetStationFromCache(station, 1);
        }

        public Station GetStationFromCache(Station station, int cacheTimeInMinutes)
        {
            ObjectCache cache = MemoryCache.Default;
            if (cache.Contains(station.name))
            {
                System.Diagnostics.Debug.WriteLine(DateTime.Now + " - CALL FROM CACHE - " + station.contract_name + " " + station.name);
                return cache.Get(station.name) as Station;
            }
            else
            {
                Station s = this.caller.GetStationInfo(station);
                System.Diagnostics.Debug.WriteLine(DateTime.Now + " - CALL FROM REST - " + station.contract_name + " " + station.name);
                // Store data in the cache
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(cacheTimeInMinutes);
                cache.Add(s.name, s, cacheItemPolicy);

                return s;
            }
        }
    }
}