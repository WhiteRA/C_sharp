using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetAndLib
{
    public interface IMessageSourceClient
    {
        void Connect(string address);
        void Disconnect();
        string ReceiveMessage();
    }
}
