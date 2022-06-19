using System.Collections.Generic;

namespace DNS.Client;

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
}
