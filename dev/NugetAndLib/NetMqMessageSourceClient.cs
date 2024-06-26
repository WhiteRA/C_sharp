using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetMQ;
using NetMQ.Sockets;

namespace NugetAndLib
{
    public class NetMqMessageSourceClient : IMessageSourceClient
    {
        private readonly SubscriberSocket _subscriberSocket;

        public NetMqMessageSourceClient()
        {
            _subscriberSocket = new SubscriberSocket();
        }

        public void Connect(string address)
        {
            _subscriberSocket.Connect(address);
            _subscriberSocket.Subscribe(""); // Subscribe to all messages
        }

        public void Disconnect()
        {
            _subscriberSocket.Close();
        }

        public string ReceiveMessage()
        {
            return _subscriberSocket.ReceiveFrameString();
        }
    }

}
