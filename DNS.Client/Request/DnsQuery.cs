using DNS.Client.Header;
using System;
using System.Collections.Generic;

namespace DNS.Client.Request
{
    public class DnsQuery
    {
        private readonly HeaderSection headerSection;

        public DnsQuery()
        {
            this.headerSection = new HeaderSection(16, 
                FlagQr.Query,
                FlagOpcode.Query, 
                FlagAuthoritativeAnswer.NotTheOwner, 
                Truncation.Permitted, 
                RecursionDesired.Desired, 
                RecursionAvailable.NotAvailable, 
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
