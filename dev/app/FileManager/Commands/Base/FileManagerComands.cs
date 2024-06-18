using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Commands.Base
{
    public abstract class FileManagerComands
    {
        public abstract void Execute(string[] args);
    }
}
