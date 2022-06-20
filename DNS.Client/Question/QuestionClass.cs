namespace DNS.Client;

public enum QuestionClass
{
    /// <summary>
    /// 1 the Internet
    /// </summary>
    /// 
    IN = 1,
    /// <summary>
    /// 2 the CSNET class (Obsolete - used only for examples in
    /// some obsolete RFCs)
    /// </summary>
    CS = 2,

    /// <summary>
    /// 3 the CHAOS class
    /// </summary>
    CH = 3,

    /// <summary>
    /// 4 Hesiod [Dyer 87]
    /// </summary>
    HS = 4
}
