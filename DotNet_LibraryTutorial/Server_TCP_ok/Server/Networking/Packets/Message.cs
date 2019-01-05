using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Networking.Packets
{
    public class Message : PacketStructure
    {
        private string _message;
        /// <summary>
        /// Length 2 byte, Type 2 byte, =4 bytes
        /// </summary>
        /// <param name="message"></param>
        public Message(string message)
            : base((ushort)(4 + message.Length), 2000)
        {
            Text = message;
        }

        public Message(byte[] packet) 
            : base(packet)
        {
        }

        public string Text
        {
            get { return ReadString(4, Data.Length - 4); }
            set
            {
                _message = value;
                WriteString(value, 4);
            }
        }
    }
}
