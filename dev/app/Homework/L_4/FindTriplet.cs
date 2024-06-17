namespace L_4
{
    public class FindTriplet
    {
        static bool FindTripletWithSum(int[] arr, int targetSum)
        {
            // Сначала сортируем массив
            Array.Sort(arr);

            int n = arr.Length;

            for (int i = 0; i < n - 2; i++)
            {
                int left = i + 1;
                int right = n - 1;

                while (left < right)
                {
                    int currentSum = arr[i] + arr[left] + arr[right];

                    // Если сумма трех чисел равна искомому числу, выводим результат и возвращаем true
                    if (currentSum == targetSum)
                    {
                        Console.WriteLine($"Тройка чисел: {arr[i]}, {arr[left]}, {arr[right]}");
                        return true;
                    }
                    else if (currentSum < targetSum)
                    {
                        left++; // Увеличиваем левый указатель, чтобы увеличить сумму
                    }
                    else
                    {
                        right--; // Уменьшаем правый указатель, чтобы уменьшить сумму
                    }
                }
            }

            // Если не найдено тройки чисел с искомой суммой, возвращаем false
            return false;
        }
    }
}