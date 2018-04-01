using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JCDecauxSoapConsoleClient.ServiceReference1;

namespace JCDecauxSoapConsoleClient
{
    class Program
    {
        SoapGatewayClient soapGateway;
        Dictionary<string, Contract> contracts;
        Dictionary<string, Station> stations;

        Program()
        {
            this.soapGateway = new SoapGatewayClient();
            this.contracts = new Dictionary<string, Contract>();
            this.stations = new Dictionary<string, Station>();
            Contract[] contractsList = this.soapGateway.GetContracts();
            foreach (Contract c in contractsList)
            {
                this.contracts.Add(c.name, c);
                foreach (Station s in this.soapGateway.GetStations(c))
                {
                    this.stations.Add(c.name + '-' + s.name, s);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("** Welcome **");
            Program p = new Program();
            p.printHelp();
            p.RunConsole();
        }

       void printHelp()
        {
            Console.WriteLine("Availables commands :");
            Console.WriteLine("\tgetCities");
            Console.WriteLine("\tgetStationsList");
            Console.WriteLine("\tgetStationInfo");
        }
       void RunConsole()
        {
            while (true)
            {
                Console.Write("JCDecaux Client > ");
                string command = Console.ReadLine();
                string[] tokens = command.Split(' ');
                switch (tokens[0])
                {
                    case "getCities":
                        Console.WriteLine(ListCities());
                        break;
                    case "getStationsList":
                        Console.WriteLine(ListStations());
                        break;
                    case "getStationInfo":
                        Console.WriteLine(StationInfo());
                        break;
                    case "help":
                        printHelp();
                        break;
                    case "exit":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
        }

        string ListCities()
        {
            string result = "Availables cities :\n";
            foreach (Contract c in this.contracts.Values) result += "\t" + c.name + "\n";
            return result;
        }

        string ListStations()
        {
            Console.Write("Which city : ");
            string city = Console.ReadLine();
            if (this.contracts.Keys.Contains(city))
            {
                Station[] stations = this.soapGateway.GetStations(this.contracts[city]);
                string result = "Available stations in " + city + " :\n";
                foreach (Station s in stations) result += "\t" + s.name + "\n";
                return result;
            }
            else
            {
                return "Unknown city";
            }           
        }

        string StationInfo()
        {
            Console.Write("Which city : ");
            string city = Console.ReadLine();
            Console.Write("Which station : ");
            string station = Console.ReadLine();
            if (this.stations.Keys.Contains(city + '-' + station))
            {
                Station stationInfo = this.soapGateway.GetStationInfo(this.stations[city + '-' + station]);
                string result = "Available informations about the station \"" + station + "\" :\n";
                result += "Address : " + stationInfo.address + "\n";
                result += "Available bikes : " + stationInfo.available_bikes + "/" + stationInfo.bike_stands + "\n";
                result += "Last update : " + stationInfo.last_update + "\n";
                return result;
            }
            else
            {
                return "Unknown station";
            }
        }
    }
}
