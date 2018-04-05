using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace JCDecauxSoapGateway
{
    public class SubscribeService : ISubscribeService
    {
        static Action<int> m_BikeAmountChanged = delegate { };
        static List<Station> stationsSupervised = new List<Station>();

        public void Subscribe(Contract c, Station s, int time)
        {
            GatewayService gw = new GatewayService();
            Station station = gw.GetStationInfo(s);
            SubscribeService.stationsSupervised.Add(station);
            ISubscribeService subscriber =
            OperationContext.Current.GetCallbackChannel<ISubscribeService>();
            //m_BikeAmountChanged += subscriber.BikeAmountChanged;
        }

       
    
    }
}