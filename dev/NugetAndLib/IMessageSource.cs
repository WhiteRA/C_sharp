using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetAndLib
{
    public interface IMessageSource
    {
        void Start();
        void Stop();
        void SendMessage(string message);
    }
}
