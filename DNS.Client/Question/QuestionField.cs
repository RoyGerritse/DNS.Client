using System;
using System.Collections.Generic;

namespace DNS.Client;

public class QuestionField
{
    public QuestionField(Question value)
    {
        Domain = value.Domain;
        Class = value.Class;
        Type = value.Type;
    }

    public string Domain { get; private set; }
    public string Class { get; private set; }
    public string Type { get; private set; }

    public string[] DomainSections => Domain.Split('.');

    public byte[] GetBytes()
    {
        var bytes = new List<byte>();
        foreach(var domainSection in DomainSections)
        {
            var length = domainSection.Length;
            bytes.Add(Convert.ToByte(length));
            foreach (char letter in domainSection)
            {
                bytes.Add(Convert.ToByte(letter));
            }
        }
        bytes.Add(0x00);

        // TODO: class and type
        bytes.Add(0x00);
        bytes.Add(0x01);

        bytes.Add(0x00);
        bytes.Add(0x01);
        return bytes.ToArray();
    }
}