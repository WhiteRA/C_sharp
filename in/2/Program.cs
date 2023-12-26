class Sharp
{
    public static void Main(string[] args)
    {
        int[,] q = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

        int[] flatArray = new int[q.Length];
        int index = 0;
        for (int i = 0; i < q.GetLength(0); i++)
        {
            for (int j = 0; j < q.GetLength(1); j++)
            {
                flatArray[index++] = q[i, j];
            }
        }

        Array.Sort(flatArray);
        index = 0;
        for (int i = 0; i < q.GetLength(0); i++)
        {
            for (int j = 0; j < q.GetLength(1); j++)
            {
                q[i, j] = flatArray[index++];
            }
        }

        for (int i = 0; i < q.GetLength(0); i++)
        {
            for (int j = 0; j < q.GetLength(1); j++)
            {
                Console.Write(q[i, j] + " ");
            }
            Console.WriteLine();
        }


        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}