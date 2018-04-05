using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace JCDecauxSoapGateway
{
    interface ISubscribeServiceEvents
    {
        [OperationContract(IsOneWay = true)]
        void Subscribe(Contract c, Station s, int seconds);

        [OperationContract(IsOneWay = true)]
        void BikeAmountChanged(int value);
    }
}