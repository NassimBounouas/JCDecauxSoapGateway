using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCDecauxSoapEventClient2
{
    internal class SubscribeServiceCallbackSink
    {
        public void BikeAmountChanged(int value)
        {
            Console.WriteLine("Bike amount has been modified : " + value);
        }
    }
}
