using System;
using System.Threading;
using System.Threading.Tasks;

namespace NugetAndLib
{

    public class Program
    {
        static async Task Main(string[] args)
        {
            IMessageSource messageSource = new NetMqMessageSource();
            IMessageSourceClient messageSourceClient = new NetMqMessageSourceClient();

            messageSource.Start();

            messageSourceClient.Connect("tcp://localhost:5556");

            await Task.Run(() =>
            {
                int count = 0;
                while (true)
                {
                    messageSource.SendMessage($"Message {count++}");
                    Thread.Sleep(1000);
                }
            });

            
            while (true)
            {
                var message = messageSourceClient.ReceiveMessage();
                Console.WriteLine($"Received: {message}");
            }
        }
    }

}
