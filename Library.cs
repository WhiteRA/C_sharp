namespace ConsoleApp
{
    /// <summary>
    /// Этот класс включает в себя методы которые понадобятся для решения задач с семинаров
    /// </summary>
    public static class Library
    {
        /// <summary>
        /// Этот метод генерирует случайное число от 10 до 999
        /// </summary>
        /// <returns></returns>
        public static int RandomNumbers_3()
        {
            int RandomNumbers = new Random().Next(10, 999);
            return RandomNumbers;
        }

        /// <summary>
        /// Этот метод генерирует случайное число от 1 до 7 
        /// </summary>
        /// <returns></returns>
        public static int RandomNumbers_1()
        {
            int RandomNumbers = new Random().Next(1, 7);
            return RandomNumbers;
        }
    }
}