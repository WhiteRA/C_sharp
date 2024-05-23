using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public static class Server
    {
        static void Main(string[] args)
        {
            int port = 11000;
            UdpClient server = new UdpClient(port);
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, port);

            try
            {
                Console.WriteLine("Ожидает подключения...");

                while (true)
                {
                    byte[] receiveBytes = server.Receive(ref clientEndPoint);
                    string receivedData = Encoding.UTF8.GetString(receiveBytes);
                    Console.WriteLine("Получено: " + receivedData);

                    string confirmationMessage = "Сообщение получено.";
                    byte[] confirmationBytes = Encoding.UTF8.GetBytes(confirmationMessage);
                    server.Send(confirmationBytes, confirmationBytes.Length, clientEndPoint);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                server.Close();
            }
        }
    }
}
