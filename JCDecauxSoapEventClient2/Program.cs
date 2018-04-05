using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCDecauxSoapEventClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** JCDecaux Event driven client");
            SubscribeServiceCallbackSink objetSink = new SubscribeServiceCallbackSink();
            objetSink.subscribe(new Contract("Toulouse"), 10);
            Console.ReadLine();
        }
    }
}
