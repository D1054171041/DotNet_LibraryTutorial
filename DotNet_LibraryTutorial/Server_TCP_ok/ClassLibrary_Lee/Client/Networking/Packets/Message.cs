using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Networking.Packets
{
    public class Message : PacketStructure
    {
        private string _message;

        public Message(string message)
            : base((ushort)(4 + message.Length),2000)
        {
            Text = message;
        }

        public string Text
        {
            get { return _message; }
            set
            {
                _message = value;
                WriteString(value, 4);
            }
        }
    }
}
