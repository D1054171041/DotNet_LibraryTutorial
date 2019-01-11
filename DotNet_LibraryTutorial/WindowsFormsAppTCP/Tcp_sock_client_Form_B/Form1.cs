using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Tcp_sock_client_Form_B
{
    public partial class Tcp_sock : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        public Tcp_sock()
        {
            int Port1 = 8080;
            int Port2 = 9000;
            InitializeComponent();
            Server_IP_textBox.Text = GetLocalIP();
            Server_Port_textBox.Text = Port1.ToString();
            Client_IP_textBox.Text = GetLocalIP();
            Client_Port_textBox.Text = Port2.ToString();
            epLocal = new IPEndPoint(IPAddress.Parse(Client_IP_textBox.Text), Convert.ToInt32(Client_Port_textBox.Text));
            epRemote = new IPEndPoint(IPAddress.Parse(Server_IP_textBox.Text), Convert.ToInt32(Server_Port_textBox.Text));

            Socket sck = new Socket(epRemote.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            Message_listBox.Items.Add("Tcp_sock_client_A.cs");
            Message_listBox.Items.Add("HELLO");

        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1";
        }



        private void Server_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Server_IP_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
               try
                {
                sck.Bind(epLocal);
                sck.Connect(epRemote);


                Message_listBox.Items.Add("Tcp Client => Tcp_sock_client_A.cs");
                Message_listBox.Items.Add("LocalEndPoint = ");
                Message_listBox.Items.Add(sck.LocalEndPoint.ToString());
                Message_listBox.Items.Add("Connected to Server = ");
                Message_listBox.Items.Add(sck.RemoteEndPoint.ToString());

                //byte[] sendmsg = Encoding.ASCII.GetBytes("This is from Client\n");

                //int n = client.Send(sendmsg);

                //int m = client.Receive(data);

                //Console.WriteLine("" + Encoding.ASCII.GetString(data));
                //client.Shutdown(SocketShutdown.Both);
                //client.Close();
            }
            catch (Exception ex)
            {
                Message_listBox.Items.Add(ex.ToString());

            }


        }
    }
}
