using System;

namespace DNS.Client.Console;

public class Program
{
    public static void Main(string[] args)
    {
        var dnsClient = new DnsClient();
        var request = new DnsQueryRequest()
        {
            TransactionId = Convert.ToUInt16("0xa05c", 16)
        };
        dnsClient.Request(request);
    }
}
