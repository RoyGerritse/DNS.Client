using System.Collections.Generic;

namespace DNS.Client;

public class ResourceRecordSection
{
    public ResourceRecordSection(string name)
    {
    }


    public byte[] GetBytes()
    {
        return new byte[]
        {
            0x00,
            0x00,
            0x29,
            0x10,
            0x00,
            0x00,
            0x00,
            0x00,
            0x00,
            0x00,
            0x0c,
            0x00,
            0x0a,
            0x00,
            0x08,
            0xf8,
            0xf6,
            0x77,
            0x19,
            0x50,
            0x5e,
            0x36,
            0x86
        };
    }
}
