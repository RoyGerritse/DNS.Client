using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DNS.Client;

public class DnsClient
{ 
    public void Request(DnsQueryRequest request)
    {
        // setup
        using var client = new UdpClient();
        IPAddress address = IPAddress.Parse("8.8.8.8");
        var port = 53;
        var ep = new IPEndPoint(address, port);
        client.Connect(ep);

        // send data
        var query = new DnsQuery(request);
        client.Send(query.GetBytes());

        // then receive data
        var receivedData = client.Receive(ref ep);
        Console.WriteLine("Receive");
        PrintByteArray(receivedData);
        var str = Encoding.ASCII.GetString(receivedData);
        Console.Write("receive data from " + ep.ToString());
        Console.WriteLine(str);
        Console.Read();
    }

    private void PrintByteArray(byte[] bytes)
    {
        var text = BitConverter.ToString(bytes);
        Console.WriteLine(text);
    }
}