using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Client.Networking
{
    public abstract class PacketStructure
    {
        private byte[] _buffer;

        public PacketStructure(ushort length, ushort type)
        {
            _buffer = new byte[length];
            WriteUShort(length, 0);
            WriteUShort(type, 2);
        }

        public void WriteUShort(ushort value, int offset)
        {
            byte[] tempBuf = new byte[2];
            tempBuf = BitConverter.GetBytes(value);
            Buffer.BlockCopy(tempBuf, 0, _buffer, offset, 2);
        }

        public void WriteUInt(uint value, int offset)
        {
            byte[] tempBuf = new byte[4];
            tempBuf = BitConverter.GetBytes(value);
            Buffer.BlockCopy(tempBuf, 0, _buffer, offset, 4);
        }

        public void WriteString(string value, int offset)
        {
            byte[] tempBuf = new byte[value.Length];
            tempBuf = Encoding.UTF8.GetBytes(value);
            Buffer.BlockCopy(tempBuf, 0, _buffer, offset, value.Length);
        }

        public void RewriteHeader(ushort length, ushort type)
        {
            WriteUShort(length, 0);
            WriteUShort(type, 2);
        }

        public byte[] Data { get { return _buffer; } }

    }
}
