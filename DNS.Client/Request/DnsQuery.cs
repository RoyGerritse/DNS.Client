using System.Collections.Generic;

namespace DNS.Client;

public class DnsQuery
{
    private readonly HeaderSection headerSection;
    private readonly QuestionSection questionSection;

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

        this.questionSection = new QuestionSection(request.Questions);
    }

    public byte[] GetBytes()
    {
        var allBytes = new List<byte>();
        allBytes.AddRange(headerSection.GetBytes());
        allBytes.AddRange(questionSection.GetBytes());
        return allBytes.ToArray();
    }
}
