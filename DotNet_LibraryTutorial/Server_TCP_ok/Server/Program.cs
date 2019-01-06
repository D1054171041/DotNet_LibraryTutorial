using System;
using Server.Networking;

namespace Server
{
    public static class Program
    {
        public static ServerSocket ServerSocket = new ServerSocket();

        static void Main(string[] args)
        {
            ServerSocket.Bind(6556);
            ServerSocket.Listen(500);
            ServerSocket.Accept();

            while (true)
                Console.ReadLine();


        }
    }
}
