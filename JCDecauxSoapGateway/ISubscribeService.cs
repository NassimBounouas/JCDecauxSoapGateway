using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace JCDecauxSoapGateway
{
    [ServiceContract(CallbackContract = typeof(ISubscribeServiceEvents))]
    public interface ISubscribeService
    {
        [OperationContract]
        void Subscribe(Contract c, Station s,  int time);
    }
}