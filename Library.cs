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
        /// Метод создиня массива
        /// </summary>
        /// <param name="count"> Является колличеством элементов массива</param>
        /// <returns></returns>
        public static int[] CreateArr(int count)
        {
            return new int[count];
        }

        /// <summary>
        /// Метод заполнения массива
        /// </summary>
        /// <param name="array"></param>
        /// <param name="min">Нижний предел генерации рандома размера массива</param>
        /// <param name="max">Верхний предел генерации рандома размера массива</param>
        public static void Fill(int[] array, int min, int max)
        {
            int size = array.Length;
            for(int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(min, max);
            }
        }
    }
}