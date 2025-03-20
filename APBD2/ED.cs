using System;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace APBD2
{
    public class ED : Device
    {
        private string _IP;

        private string _network;

        // addmiting I took this from the internet cause i was unsure how to format IP address correctly 
        private Regex _regex = new Regex(
            @"^((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\.){3}(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])$");

        public ED(int id, string name, string ip, string network) : base(id, name)
        {
            if (_regex.IsMatch(ip))
            {
                throw new ArgumentException("Invalid IP address format");
            }

            _IP = ip;
            _network = network;
        }

        public void Connect()
        {
            if (!_network.Contains("MD Ltd."))
                throw new ConnectionException($"{Name} cannot connect. Invalid network name!");

            Console.WriteLine($"Connected to {_network}.");
        }

        public override void TurnOn()
        {
            Connect();
            base.TurnOn();
        }
    }
}
public class ConnectionException : Exception
{
    public ConnectionException(string message) : base(message) { }
}