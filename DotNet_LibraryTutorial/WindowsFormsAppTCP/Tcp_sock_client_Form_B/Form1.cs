using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Tcp_sock_client_Form_B
{
    public partial class Tcp_sock : Form
    {
        int Port1 = 8080;
        int Port2 = 9000;
        Socket sckClient,sckServer;
        EndPoint epLocalServer, epRemoteServer;
        EndPoint epLocalClient, epRemoteClient;
        public Tcp_sock()
        {
            InitializeComponent();
            Local_IP_textBox.Text = GetLocalIP();
            L_Server_Port_textBox.Text = Port1.ToString();
            L_Client_Port_textBox.Text = Port2.ToString();

            epLocalServer = new IPEndPoint(IPAddress.Parse(Local_IP_textBox.Text), Convert.ToInt32(L_Server_Port_textBox.Text));
            epRemoteServer = new IPEndPoint(IPAddress.Parse(Remote_IP_textBox.Text), Convert.ToInt32(R_Server_Port_textBox.Text));

            Socket sck = new Socket(epRemoteServer.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Remote_IP_textBox.Text = GetLocalIP();
            R_Server_Port_textBox.Text = (Port1+1).ToString();
            R_Client_Port_textBox.Text = (Port2+1).ToString();

        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
               try
                {
                sckClient.Bind(epLocalServer);
                sckClient.Connect(epRemoteServer);


                Message_listBox.Items.Add("Tcp Client => Tcp_sock_client_A.cs");
                Message_listBox.Items.Add("LocalEndPoint = ");
                Message_listBox.Items.Add(sckClient.LocalEndPoint.ToString());
                Message_listBox.Items.Add("Connected to Server = ");
                Message_listBox.Items.Add(sckClient.RemoteEndPoint.ToString());

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
