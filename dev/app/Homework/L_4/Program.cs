namespace L_4
{
    public class Progam
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 4, 45, 6, 10, 8 };
            int targetSum = 22;

            if (!FindTripletWithSum(arr, targetSum))
            {
                Console.WriteLine("Тройка чисел с заданной суммой не найдена");
            }
        }
    }
}