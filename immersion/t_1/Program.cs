using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
        {
            char sign = args[1][0];
            if (int.TryParse(args[0], out int num1) && int.TryParse(args[2], out int num2))
            {
                switch (sign)
                {
                    case '+':
                        System.Console.WriteLine(num1 + num2);
                        break;
                    case '-':
                        System.Console.WriteLine(num1 - num2);
                        break;
                    case '*':
                        System.Console.WriteLine(num1 * num2);
                        break;
                    case '/':
                        System.Console.WriteLine(num1 / num2);
                        break;
                    default:
                        System.Console.WriteLine("Такого символа нет");
                        break;
                }
            }
            else
            {
                System.Console.WriteLine("Правильный ввод а + в ");
            }
        }
        else
        {
            System.Console.WriteLine("Неверный ввод");
        }
        }
    }
}
