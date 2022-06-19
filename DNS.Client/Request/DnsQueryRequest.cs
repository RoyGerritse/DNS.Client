using DNS.Client.Header;

namespace DNS.Client
{
    public class DnsQueryRequest
    {
        public ushort TransactionId { get; set; }
        public FlagQr FlagQr { get; set; }
        public FlagOpcode FlagOpcode { get; set; }
        public FlagAuthoritativeAnswer FlagAuthoritativeAnswer { get;set;}
        public Truncation Truncation { get; set; }
        public RecursionDesired RecursionDesired { get; set; }
        public RecursionAvailable RecursionAvailable { get; set; }
    }
}