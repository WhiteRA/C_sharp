using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class Client
    {
        static void Main(string[] args)
        {
            string userName = args.Length > 0 ? args[0] : "DefaultUser";
            string serverIP = args.Length > 1 ? args[1] : "127.0.0.1";
            int serverPort = 11000;

            UdpClient client = new UdpClient();
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);
            

            try
            {
                while (true)
                {
                    Console.Write("Ввод сообщения: ");
                    string message = Console.ReadLine();
                    string fullMessage = $"{userName}: {message}";
                    byte[] sendBytes = Encoding.UTF8.GetBytes(fullMessage);

                    client.Send(sendBytes, sendBytes.Length, serverEndPoint);

                    byte[] recBytes = client.Receive(ref serverEndPoint);
                    string receivedData = Encoding.UTF8.GetString(recBytes);
                    Console.WriteLine("Получено: " + receivedData);

                    client.Client.ReceiveTimeout = 5000; // Таймаут ожидания 5 секунд
                    try
                    {
                        byte[] receiveBytes = client.Receive(ref serverEndPoint);
                        string response = Encoding.UTF8.GetString(receiveBytes);
                        Console.WriteLine("Ответ сервера: " + response);
                    }
                    catch (SocketException)
                    {
                        Console.WriteLine("Подтверждение от сервера не получено.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                client.Close();
            }
        }
    }
}
