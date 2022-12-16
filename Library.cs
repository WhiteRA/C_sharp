﻿using System;

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
    }
}