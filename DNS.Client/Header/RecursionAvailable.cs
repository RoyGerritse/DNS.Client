namespace DNS.Client.Header
{
    public enum RecursionAvailable : byte
    {
        NotAvailable = 0,
        Available = 1 << 0,
    }
}