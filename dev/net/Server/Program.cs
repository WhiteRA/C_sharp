using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace L_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket lisn = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint locEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            lisn.Blocking = true;
            lisn.Bind(locEndPoint);
            lisn.Listen(100);
            Console.WriteLine("чтото тут есть ");
            Socket socket = lisn.Accept();
            Console.WriteLine("опять чтото есть");
            lisn.Close();
        }
    }
}
