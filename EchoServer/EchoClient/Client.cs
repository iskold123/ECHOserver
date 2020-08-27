using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace EchoClient
{
    class Client
    {
        public void Start()
        {
            TcpClient socket = new TcpClient("localhost",7);

            StreamReader sr = new StreamReader(socket.GetStream());
            StreamWriter sw = new StreamWriter(socket.GetStream());

            String message = "Mads";
            sw.WriteLine(message);
            sw.Flush();

            String returnmessage = sr.ReadLine();
            Console.WriteLine($"Retur fra server: {returnmessage}");

            socket.Close();

        }


    }
}
