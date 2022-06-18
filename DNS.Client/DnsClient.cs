using System;
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



            string text = "roygerritse.nl: type A, class IN";
            byte[] bytes = Encoding.ASCII.GetBytes(text);


            var client = new UdpClient();
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("8.8.8.8"), 53); // endpoint where server is listening
            client.Connect(ep);

            // send data
            client.Send(bytes);

            // then receive data
            var receivedData = client.Receive(ref ep);
            var str = Encoding.ASCII.GetString(receivedData);
            Console.Write("receive data from " + ep.ToString());
             Console.WriteLine(str);
            Console.Read();
        }
    }
}
