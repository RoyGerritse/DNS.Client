using DNS.Client.Header;
using System;
using System.Collections.Generic;

namespace DNS.Client.Request
{
    
    public class DnsQuery
    {
        private readonly HeaderSection headerSection;

        public DnsQuery(DnsQueryRequest request)
        {
            this.headerSection = new HeaderSection(request.TransactionId, 
                request.FlagQr,
                request.FlagOpcode, 
                request.FlagAuthoritativeAnswer, 
                request.Truncation, 
                request.RecursionDesired, 
                request.RecursionAvailable, 
                1,
                0,
                0,
                1);
        }

        public byte[] GetBytes()
        {
            var allBytes = new List<byte>();
            byte[] headerBytes = headerSection.ToByteArray();
            allBytes.AddRange(headerBytes);
            return allBytes.ToArray();
        }

        public void PrintBytes()
        {
            foreach (byte i in GetBytes())  
            {
                Console.Write("{0:X2} ", i); // <- A byte is being passed.
            }
        }
    }
}
