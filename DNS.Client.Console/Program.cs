using System;
using System.Collections.Generic;

namespace DNS.Client.Console;

public class Program
{
    public static void Main(string[] args)
    {
        var dnsClient = new DnsClient();
        var request = new DnsQueryRequest()
        {
            TransactionId = Convert.ToUInt16("0xa05c", 16),
            FlagQr = FlagQr.Query,
            FlagOpcode = FlagOpcode.Query,
            Truncation = Truncation.Permitted,
            RecursionDesired = RecursionDesired.Desired,
            Questions = new List<Question>
            {
                new Question
                {
                    Domain = "google.nl",
                    Type = QuestionType.A,
                    Class = QuestionClass.IN
                },
                new Question
                {
                    Domain = "roygerritse.nl",
                    Type = QuestionType.A,
                    Class = QuestionClass.IN
                }
            }
        };
        dnsClient.Request(request);
    }
}
