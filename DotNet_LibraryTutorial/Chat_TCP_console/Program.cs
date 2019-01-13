//http://cs0.wikidot.com/chatbox
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

class ChatBox
{
    int port = 20;

    public static void Main(String[] args)
    {
        ChatBox chatBox = new ChatBox();
        if (args.Length == 0)
            chatBox.ServerMain();
        else
            chatBox.ClientMain(args[0]);
    }

    public void ServerMain()
    {
        IPEndPoint ipep = new IPEndPoint(IPAddress.Any, port);
        Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        newsock.Bind(ipep);
        newsock.Listen(10);
        Socket client = newsock.Accept();
        new TcpListener(client); // create a new thread and then receive message.
        newsock.Close();
    }

    public void ClientMain(String ip)
    {
        IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        server.Connect(ipep);
        new TcpListener(server);
        server.Shutdown(SocketShutdown.Both);
        server.Close();
    }

}

public class TcpListener
{
    Socket socket;
    Thread inThread, outThread;
    NetworkStream stream;
    StreamReader reader;
    StreamWriter writer;

    public TcpListener(Socket s)
    {
        socket = s;
        stream = new NetworkStream(s);
        reader = new StreamReader(stream);
        writer = new StreamWriter(stream);
        inThread = new Thread(new ThreadStart(inLoop));
        inThread.Start();
        outThread = new Thread(new ThreadStart(outLoop));
        outThread.Start();
        inThread.Join(); // 等待 inThread 執行續完成，才離開此函數。 
        // (注意、按照 inLoop 的邏輯，這個函數永遠不會跳出，因為 inLoop 是個無窮迴圈)。
    }

    public void inLoop()
    {
        while (true)
        {
            String line = reader.ReadLine();
            Console.WriteLine("收到：" + line);
        }
    }

    public void outLoop()
    {
        while (true)
        {
            String line = Console.ReadLine();
            writer.WriteLine(line);
            writer.Flush();
        }
    }
}