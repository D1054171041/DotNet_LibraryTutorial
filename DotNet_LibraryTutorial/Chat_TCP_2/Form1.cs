//https://www.youtube.com/watch?v=X16IyNbcAr0&feature=youtu.be
//https://youtu.be/ObcGBT4ZWEU
//C# Tutorial 78: How to make a Chat Program in C# Part 1234
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System;

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
            ServerPortTextBox.Text = "8080";
        }

        private void BtnStart_Click(object sender, System.EventArgs e)
        {
           // TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(ServerPortTextBox.Text));
            TcpListener listener = new TcpListener(IPAddress.Parse(ServerIPtextBox.Text), int.Parse(ServerPortTextBox.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;

        }

        private void BtnConnect_Click(object sender, System.EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IPEnd = new IPEndPoint(IPAddress.Parse(ClientIPtextBox.Text), int.Parse(ClientPortTextBox.Text));
            try
            {
                client.Connect(IPEnd);
                if(client.Connected)
                {
                    ChatScreenTextBox.AppendText("Connected to Server ok" + "\n");
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    this.ChatScreenTextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatScreenTextBox.AppendText("You:" + receive + "\n");
                    }));
                    receive = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.ChatScreenTextBox.Invoke(new MethodInvoker(delegate ()
                {
                    ChatScreenTextBox.AppendText("Me:" + TextToSend + "\n");
                }));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (MessageTextBox.Text != "")
            {
                TextToSend = MessageTextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            //MessageTextBox.Text = "";
        }

        private void btnGetHostIP_Click(object sender, EventArgs e)
        {
            ClientIPtextBox.Text = ServerIPtextBox.Text;
            ClientPortTextBox.Text = ServerPortTextBox.Text;
        }
    }
}
