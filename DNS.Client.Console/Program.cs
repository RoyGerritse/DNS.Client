using System;
using DNS.Client;

namespace DNS.Client.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dnsClient = new DnsClient();
            dnsClient.Request();
        }
    }
}
