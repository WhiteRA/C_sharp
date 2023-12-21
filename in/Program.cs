class Sharp
{
    public static void Main(string[] args)
    {
        foreach (string a in args)
        {

        }
        if (args.Length > 3)
        {
            Console.WriteLine("Вверное построение условия");
        }
        else
        {
            int a = int.Parse(args[0]);
            int b = int.Parse(args[2]);

            switch (args[1])
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Делить на 0 нельзя.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{a} / {b} = {Convert.ToDouble(a / b)}");
                        break;
                    }
                default:
                    Console.WriteLine("Нет такого оператора");
                    break;

            }
        }
    }
}
