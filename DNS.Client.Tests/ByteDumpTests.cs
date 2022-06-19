namespace DNS.Client.Tests;

[TestClass]
public class ByteDumpTests
{
    [TestMethod]
    public void DefaultQuery()       
    {
        // 0xa05c A google.nl OPT
        // Arange
        var byteDump = new byte[27] {
            0xa0, // Transaction byte 1
            0x5c, // Transaction byte 2
            0x01, // Flag byte 1
            0x20, // Flag byte 2
            0x00, // Questions byte 1
            0x01, // Questions byte 2
            0x00, // Answer RRs byte 1
            0x00, // Answer RRs byte 2
            0x00, // Authority RRs byte 1
            0x00, // Authority RRs byte 2
            0x00, // Additional RRs byte 1
            0x01, // Additional RRs byte 2
            0x06, // 6 count of letter 'google'
            0x67, // g
            0x6f, // o
            0x6f, // o
            0x67, // g
            0x6c, // l
            0x65, // e
            0x02, // 2 count of 'nl'
            0x6e, // n
            0x6c, // l
            0x00, // Question ending 0
            0x00, // Question type byte 1
            0x01, // Question type byte 2
            0x00, // Question class byte 1
            0x01, // Question class byte 2
            //0x00,
            //0x00,
            //0x29,
            //0x10,
            //0x00,
            //0x00,
            //0x00,
            //0x00,
            //0x00,
            //0x00,
            //0x0c,
            //0x00,
            //0x0a,
            //0x00,
            //0x08,
            //0xf8,
            //0xf6,
            //0x77,
            //0x19,
            //0x50,
            //0x5e,
            //0x36,
            //0x86
        };

        var request = new DnsQueryRequest
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
                    Type = "A",
                    Class = "IN"
                }
            }
        };
        
        // Act
        var query = new DnsQuery(request);
        var bytes = query.GetBytes();

        // Assert
        Assert.AreEqual(bytes.Length, bytes.Length);
        CollectionAssert.AreEqual(byteDump, bytes);
    }
}