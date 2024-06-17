using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class ConsoleUserInterface : IUserInterface
    {
        public string ReadText(string text, bool TextNewLine = true)
        {
            if (text is { Length: > 0 })
            {
                if (TextNewLine)
                {
                    WriteText(text);
                }
                else
                {
                    Write(text);
                }
            }
            return Console.ReadLine();
        }

        public void Write(string str)
        {
            Console.Write(str);
        }

        public void WriteText(string str)
        {
            Console.WriteLine(str);
        }
    }
}
