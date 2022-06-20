using System;
using System.Collections.Generic;

namespace DNS.Client;

public class ResouceNameField
{
    public ResouceNameField(string value)
    {
        Value = value;
    }

    public string Value { get; private set; }

    public byte[] GetBytes()
    {
        var bytes = new List<byte>();
        return bytes.ToArray();
    }
}