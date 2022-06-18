using System;
using DNS.Client;

namespace DNS.Client.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            var dnsClient = new DnsClient();
            dnsClient.Request();
        }
    }
}
