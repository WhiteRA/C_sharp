using System;
using System.Runtime.CompilerServices;

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

        /// <summary>
        /// Метод вывода массива чтобы числа выводились с пробелом
        /// </summary>
        /// <param name="array">Массив для вывода</param>
        /// <returns></returns>
        public static string PrintMass(int[] array)
        {
            string r = String.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            return r;
        }

        /// <summary>
        /// Метод вывода массива сумм элементов, стоящих на нечётных позициях.
        /// </summary>
        /// <param name="array">Массив для расчёта</param>
        /// <returns></returns>
        public static int SumNonPositions(int[] array)
        {
            int v = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    v += array[i];
                }
            }
            return v;
        }

        /// <summary>
        /// Метод вывода поиска количества чётных чисел в массиве и подсчёт их колличества.
        /// </summary>
        /// <param name="array">Массив для расчёта</param>
        /// <returns></returns>
        public static int EvenNumbersInArray(int[] array)
        {
            int q = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 10) % 2 == 0)
                {
                    q++;
                }
                if (((array[i] / 10) % 10) % 2 == 0)
                {
                    q++;
                }
                if (((array[i] / 100) % 10) % 2 == 0)
                {
                    q++;
                }
            }
            return q;
        }

        /// <summary>
        /// Метод создания вещественного массива массива 
        /// </summary>
        /// <param name="count">Колличество элементов массива</param>
        /// <returns></returns>
        public static double[] DobleCrtArr(double count)
        {
            return new double[(int)count];
        }

        /// <summary>
        /// Метод заполнения массива случайными вещественными числами 
        /// </summary>
        /// <param name="array">массив который надо заполнить</param>
        /// <param name="min">минимальный элемент заполнения</param>
        /// <param name="max">максимальный  элемент заполнения</param>
        /// <returns></returns>
        public static void DobleСomplArr(double[] array, int min, int max)
        {
            int size = array.Length;
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(min, max) + rand.NextDouble();
            }
        }

        /// <summary>
        /// Метод округления вещественных чисел до N знаков после запятой
        /// </summary>
        /// <param name="array">массив в котором нужно произвести округление</param>
        /// <param name="N">До какого числа после запятой происходит округление</param>
        /// <returns></returns>
        public static void RoundingDoble(double[] array, int N)
        {
            double F = 0;
            for (int i = 0; i < array.Length; i++)
            {
                F = Math.Round(array[i], N);
                Console.Write($"{F} ");
            }
        }

        /// <summary>
        /// Метод поиска минимального и максимального значения в массиве вещественных чисел
        /// </summary>
        /// <param name="array">массив в котором нужно произвести поиск</param>
        /// <returns></returns>
        public static void DobleSearch(double[] array)
        {
            double min = 0;
            double max = 0;
            for (int z = 0; z < array.Length; z++)
            {
                if (array[z] > max)
                {
                    max = Math.Round(array[z], 2);
                }
                if (array[z] < min)
                {
                    min = Math.Round(array[z], 2);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"MAX {max} | MIN {min}|");
        }

        /// <summary>
        /// Метод ввода чисел в массив с клавы
        /// </summary>
        /// <param name="array">массив в который нужно записать</param>
        /// <returns></returns>
        public static void ManuallyNumbersArray(int[] array)
        {
            int size = array.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Ввести число массива ");
                int y = Convert.ToInt32(Console.ReadLine());
                array[i] = y;
            }
        }

        /// <summary>
        /// Метод поиска количества элементов массива больше 0
        /// </summary>
        /// <param name="mass">массив в который нужно записать</param>
        /// <returns></returns>
        public static int SearchingNumberArray(int[] mass)
        {
            int q = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= q)
                {
                    q++;
                }
            }
            return q;
        }

        /// <summary>
        /// Метод определения точки координат пересечения 2-х прямых 
        /// </summary>
        /// <returns></returns>
        public static void DeterminingPointCoordinates(double z, double b, double c, double v)
        {
            double x = (-(c - v)) / (z - b);
            double y = z * x + v;
            Console.WriteLine($"Точка пересечения прямых ({x}; {y})");
        }

        /// <summary>
        /// Метод создания двумерного массива содержащий значения INT
        /// </summary>
        /// <param name="x">Колличество строк массива</param>
        /// <param name="y">Колличество столбцов массива</param>
        /// <returns></returns>
        public static int[,] CrtTwoDimArr(int x, int y)
        {
            return new int[x, y];
        }


        /// <summary>
        /// Метод печати двумерного массива содержащий значения INT
        /// </summary>
        /// <param name="matrix">массив который надо распечатать</param>
        /// <returns></returns>
        public static void PrintTwoDimArr(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод заполнения двумерного массива содержащий значения INT
        /// </summary>
        /// <param name="matrix">массив который надо заполнить</param>
        /// <returns></returns>
        public static void FillTwoDimArr(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(1, 10);
                }
            }
        }

        /// <summary>
        /// Метод создания двумерного массива содержащий значения DOUBLE
        /// </summary>
        /// <param name="matrix">массив который надо заполнить</param>
        /// <returns></returns>
        public static void CrtTwoDimRealArr(double[,] matrix)
        {
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Math.Round(rand.Next(-10, 10) + rand.NextDouble(), 2);
                    Console.Write($" {matrix[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод поиска элемента по координатам содержащий значения INT
        /// </summary>
        /// <param name="matrix">массив который надо заполнить</param>
        /// <param name="x">Колличество строк массива</param>
        /// <param name="y">Колличество столбцов массива</param>
        /// <returns></returns>
        public static int SearchingElementCoordinates(int[,] matrix, int x, int y)
        {
            int l = 0;
            if (x > 3)
            {
                Console.WriteLine($"Координаты числа выходят за пределы размера марицы");
            }
            else if (y > 4)
            {
                Console.WriteLine($"Координаты числа выходят за пределы размера марицы");
            }
            else
            {
                l = matrix[x, y];
                Console.WriteLine($"Число c данными координатами - {l}");
            }
            return l;
        }

        /// <summary>
        /// Метод поиска среднего арифметического в массиве содержащий значения DOUBLE
        /// </summary>
        /// <param name="matrix">массив который надо заполнить</param>
        /// <returns></returns>
        public static void ArithmeticMeanArray(int[,] matrix)
        {
            double s = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    s += matrix[i, j];
                }
                Console.Write($"= {s / matrix.GetLength(0)}; ");
            }
        }

        /// <summary>
        /// Метод сортировки пузярьком одномерного массива 
        /// </summary>
        /// <param name="mass">массив который надо отсортировать</param>
        /// <returns>Возвращает отсортированный массив</returns>
        public static int[] BubbleSorting(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length - 1; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        int t = mass[j + 1];
                        mass[j + 1] = mass[j];
                        mass[j] = t;
                    }
                }
            }
            return mass;
        }
    }
}