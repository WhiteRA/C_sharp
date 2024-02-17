using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t_2
{
    /// <summary>
    /// Класс для доп-инструментов
    /// </summary>
    public class Add
    {
        /// <summary>
        /// Сортируем двумерный массив.
        /// </summary>
        /// <param name="arr">Положи сюда двумерный массив</param>
        public static void sortTwoDimArr(int[,] arr)
        {
            /* 
             * Хитрость в том, что потрошим двумерный массив и заливаем 
             * содержимое в одномерный. Затем делаем сортировку (пузырь наше всё) 
             * одномерного и возвращаем элементы уже отсортированного одномерного
             * в двумерный.
            */
            int[] b = new int[arr.GetLength(0) * arr.GetLength(1)];
            int p = 0, f; 
            // p - используется как порядковый номер для одномерного массива.
            // f - просто как буфер для перекладывания значений в массиве.


            // тут перекладываем из 2 мерного в 1 мерный 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    b[p] = arr[i, j];
                    p++;
                }
            }

            //сорт в одномерном
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(0) - 1; j++)
                {
                    if (b[j] > b[j + 1])
                    {
                        f = b[j];
                        b[j] = b[j + 1];
                        b[j + 1] = f;
                    }
                }
            }

            //возвращаем обратно отсортированные значения в пришедший массив.
            p = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = b[p];
                    p++;
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
