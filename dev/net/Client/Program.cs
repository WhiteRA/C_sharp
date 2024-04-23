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
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint removeEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            Console.WriteLine("кудато цепляюсь");
            client.Connect(removeEndPoint);
            Console.WriteLine("подцепился");
            client.Close();
        }
    }
}
