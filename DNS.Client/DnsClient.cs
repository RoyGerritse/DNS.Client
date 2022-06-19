using DNS.Client.Header;
using DNS.Client.Request;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DNS.Client
{

    public class DnsClient
    {
        public DnsClient()
        {

        }

        public void Request()
        {
            // setup
            using var client = new UdpClient();
            IPAddress address = IPAddress.Parse("8.8.8.8");
            var port = 53;
            var ep = new IPEndPoint(address, port);
            client.Connect(ep);

            // send data
            var request = new DnsQuery();
            request.PrintBytes();
            client.Send(request.GetBytes());

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

}