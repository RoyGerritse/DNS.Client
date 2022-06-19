﻿namespace DNS.Client.Header
{
    internal class RecursionAvailableField
    {
        private RecursionAvailable value;

        public RecursionAvailableField(RecursionAvailable value)
        {
            this.value = value;
        }

        public byte GetByte()
        {
            return (byte)value;
        }
    }
}