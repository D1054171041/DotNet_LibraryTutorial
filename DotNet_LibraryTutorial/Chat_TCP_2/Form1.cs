//https://www.youtube.com/watch?v=X16IyNbcAr0&feature=youtu.be
//https://youtu.be/ObcGBT4ZWEU
//C# Tutorial 78: How to make a Chat Program in C# Part 1234
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Chat_TCP_2
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public string TextToSend;
        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPtextBox.Text = address.ToString();
                }
            }
        }
    }
}
