namespace DNS.Client.Header
{
    public enum Truncation : byte
    {
        Permitted = 0,
        Truncated = 1 << 0
    }
}