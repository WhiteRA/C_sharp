using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public interface IUserInterface
    {
        void WriteText(string str); // TODO : выводить в интерфес что либо
        void Write(string str);

        string ReadText(string text, bool TextNewLine = true); // TODO : писать в интерфес что либо
        
    }
}
