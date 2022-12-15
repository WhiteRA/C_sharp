namespace ConsoleApp
{
    /// <summary>
    /// Этот класс включает в себя методы которые понадобятся для решения задач с семинаров
    /// </summary>
    public static class Library
    {
        /// <summary>
        /// Метод генерирует случайное число от 10 до 999
        /// </summary>
        /// <returns></returns>
        public static int RandomNumbers_3()
        {
            int RandomNumbers = new Random().Next(10, 999);
            return RandomNumbers;
        }

        /// <summary>
        /// Метод генерирует случайное число от 1 до 10 
        /// </summary>
        /// <returns></returns>
        public static int RandomNumbers_1()
        {
            int RandomNumbers = new Random().Next(1, 10);
            return RandomNumbers;
        }

        /// <summary>
        /// Метод создания массива 
        /// </summary>
        /// <param name="count">Колличество элементов массива</param>
        /// <returns></returns>
        public static int[] CrtArr(int count)
        {
            return new int[count];
        }

        /// <summary>
        /// Метод Заполнения массива случайными элементами 
        /// </summary>
        /// <param name="array">массив который нзаполнить</param>
        /// <param name="min">минимальный элемент заполнения</param>
        /// <param name="max">максимальный  элемент заполнения</param>
        /// <returns></returns>
        public static void СomplArr(int[] array, int min, int max)
        {
            int size = array.Length;
            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(min, max);
            }
        }

        /// <summary>
        /// Метод переводит масив в строку
        /// </summary>
        /// <param name="array">массив который необходимо вывести</param>
        /// <returns></returns>
        public static string ShowArrayToString(int[] array)
        {
            string result = String.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 10) result += $"A";
                else if (array[i] == 11) result += $"B";
                else if (array[i] == 12) result += $"C";
                else if (array[i] == 13) result += $"D";
                else if (array[i] == 14) result += $"E";
                else result += $"{array[i]}";
            }
            return result;
        }

        /// <summary>
        /// Метод возведния в степень 
        /// </summary>
        /// <param name="a">Возводимое число</param>
        /// <param name="b">Степерь числа</param>
        /// <returns></returns>
        public static int Pow(int a, int b)
        {
            int s = 1;
            for (int i = 0; i < b; i++)
            {
                s *= a;
            }
            return s;
        }

        /// <summary>
        /// Метод перевода из 15-и ричной системы в 10-ую
        /// </summary>
        /// <param name="value">Массив для перевода</param>
        /// <returns></returns>
        public static int NdimNumSys(int[] value)
        {
            int r = 0;
            int count = value.Length;
            for (int i = 0; i < count; i++)
            {
                r += value[i] * Pow(15, count - 1 - i);
            }
            return r;
        }
    }
}