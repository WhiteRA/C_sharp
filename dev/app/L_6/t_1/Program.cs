using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // Целые числа
            Console.WriteLine("Сложение (целые числа): " + calc.Add(5, 3));
            Console.WriteLine("Вычитание (целые числа): " + calc.Subtract(5, 3));
            Console.WriteLine("Умножение (целые числа): " + calc.Multiply(5, 3));
            Console.WriteLine("Деление (целые числа): " + calc.Divide(5, 3));

            // Дробные числа
            Console.WriteLine("Сложение (дробные числа): " + calc.Add(5.5, 3.3));
            Console.WriteLine("Вычитание (дробные числа): " + calc.Subtract(5.5, 3.3));
            Console.WriteLine("Умножение (дробные числа): " + calc.Multiply(5.5, 3.3));
            Console.WriteLine("Деление (дробные числа): " + calc.Divide(5.5, 3.3));
        }
    }

}
