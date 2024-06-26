using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetMQ;
using NetMQ.Sockets;

namespace NugetAndLib
{
    public class NetMqMessageSource : IMessageSource
    {
        private readonly PublisherSocket _publisherSocket;

        public NetMqMessageSource()
        {
            _publisherSocket = new PublisherSocket();
        }

        public void Start()
        {
            _publisherSocket.Bind("tcp://*:5556");
        }

        public void Stop()
        {
            _publisherSocket.Close();
        }

        public void SendMessage(string message)
        {
            _publisherSocket.SendFrame(message);
        }
    }

}
