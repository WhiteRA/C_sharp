namespace ConsoleApp
{
    public static class Library
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int RandomNumbers()
        {
            int RandomNumbers = new Random().Next(10, 999);
            return RandomNumbers;
        }
    }
}