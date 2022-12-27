
using System;
using System.Formats.Asn1;
using static ConsoleApp.Library;

/*
//Первое ДЗ

//Задача 1: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Задание 1");
Console.WriteLine("Начало");
int a = 2;
int b = 3;
int c = 7;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max = ");
Console.WriteLine(max);
Console.WriteLine("Конец");
Console.WriteLine(" ");


//Задача 2: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Задание 2");
Console.WriteLine("Начало");
int w = 4;
int s = -3;
int x = 7;
int even = 0;
if (w % 2 == 0) even = w;
if (s % 2 == 0) even = s;
if (x % 2 == 0) even = x;
Console.Write("Чётное число = ");
Console.WriteLine(even);
Console.WriteLine("Конец");
Console.WriteLine(" ");

//Задача 3: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Задание 3");
Console.WriteLine("Начало");
int e = 5;
int f = 8;
int i = 0;
int j = 0;
int even1 = 0;
int even2 = 0;
while (i < e)
{
    if (i % 2 == 0)
    {
        if (i == 0)
        {

        }
        else
        {
            even1 = i;
            Console.Write("Чётное число = ");
            Console.WriteLine(even1);
        }
    }
    
    i++;
}
Console.WriteLine("-----");

while (j < f)
{
    if (j % 2 == 0)
    {
        if (j == 0)
        {

        }
        else
        {
            even2 = j;
            Console.Write("Чётное число = ");
            Console.WriteLine(even2);
        }
    }
    j++;
}
Console.WriteLine("-----");
Console.WriteLine("Конец");
Console.WriteLine(" ");



//Второе ДЗ

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System.Xml.Linq;

int i = RandomNumbers_3(); // Тут генерируем число
Console.WriteLine(i + " - Случайное число");  // Выводим получившиеся число
i = (i / 10) % 10;                            // Берём число, делим его на 10. К примеру 123, делим на 10. Получается 12,3. Но так-как у нас INT, в топеременную i падает 12. Азатем получаем остаток от деления на 10 числа 12 = 2. Это и будет вторая цифра числа 123.
Console.WriteLine(i + " - Вторая цифра");     // Выводим ответ.
Console.WriteLine();


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int o = RandomNumbers_3();
Console.WriteLine(o + " - Случайное число");
o = o % 10;
Console.WriteLine(o + " - Третья цифра");    // Выводим ответ.
Console.WriteLine();


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Проверка дня недели на выходной день.");
Console.WriteLine("Укажите номер дня недели");
string weekday = Console.ReadLine();
int d = Convert.ToInt32(weekday);

if (d <= 7)
{
    switch (d)  // Я решил использувать оператор свитч потому, что он показался мне очень подходящим для этой задачи.
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;
        case 2:
            Console.WriteLine("Вторник");
            break;
        case 3:
            Console.WriteLine("ЭТО СРЕДА, МОИ ПРОГРАММИСТСКИЕ ЧУВАКИ");
            break;
        case 4:
            Console.WriteLine("Четверг");
            break;
        case 5:
            Console.WriteLine("Пятница");
            break;
        case 6:
            Console.WriteLine("Суббота, обычно выходной");
            break;
        case 7:
            Console.WriteLine("Воскресенье, обычно выходной");
            break;
    }
}
else 
{
    Console.WriteLine("Такого номера дня недели не существует");
}



//Третье ДЗ

//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int i, r = 0, n = 0;
Console.WriteLine("Введите число: ");
int u = Convert.ToInt32((Console.ReadLine()));
for (i = u; i > 0; i = (i / 10))
{
    r = i % 10;
    Console.Write(r);
    n = n*10 + r;
}

if (n == u)
{
    Console.WriteLine("Это палиндром");
}else
{
    Console.WriteLine("Это не палиндром");
}


//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int A1 = RandomNumbers_1();
int A2 = RandomNumbers_1();
int B1 = RandomNumbers_1();
int B2 = RandomNumbers_1();

double L = Math.Sqrt(Math.Pow((A2 - A1), 2) + Math.Pow((B2 - B1), 2));
if (L == 1)
{
    Console.WriteLine("Растояние = " + Math.Round(L, 2) + " бублику");
}else
{
    Console.WriteLine("Растояние = " + Math.Round(L, 2) + " бубликов");
}


//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите значение");
int p = Convert.ToInt32((Console.ReadLine()));
Console.Clear();
int k = 1;

for (int m = 1; m <= p; m++)
{

    Console.Write(i + " ");
    k = i * i * i;
    Console.WriteLine(u);
}


//Четвёртове ДЗ
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int number = RandomNumbers_1();
int degree = RandomNumbers_1();
int result = 1;
for (int i = 0; i < degree; i++)
{
    result *= number;
    Console.WriteLine(result);
}
Console.Write($"{number} в степени {degree} = {result}");


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int a = RandomNumbers_3();
string b = a.ToString();
int N = b.Length;
int p = 1;
int M = 0;
Console.WriteLine(a);
for (int i = 1; i <= N; i++)
{
    M += (a / p) % 10;
    p *= 10;
    Console.Write($"{M} ");
}


//Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15

int[] g = CrtArr(5); // создаю массив размером 5 с помощью метода CrtArr
СomplArr(g, 1, 15);  // заполняю массив g случайными значениями от 1 до 15 с помощью метода СomplArr
int v = NdimNumSys(g);  // перевожу массив из 15-ти в 10 ричную систему счисления с помощью метода NdimNumSys. Так-же внутри этого метода есть условие заменяющие все цифры больше 10 на буквы
Console.WriteLine($"{ShowArrayToString(g)} = {v}"); // вывожу сгенерированный массив и переведённый



//Пятое ДЗ
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] ar = CrtArr(3);
СomplArr(ar, 100, 999);
PrintMass(ar);
Console.WriteLine();
Console.WriteLine(EvenNumbersInArray(ar));


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] rg = CrtArr(4);
СomplArr(rg, 1, 99);
PrintMass(rg);
Console.WriteLine();
Console.WriteLine(SumNonPositions(rg));



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] vc = DobleCrtArr(4); // Создаём массив вещественных чисел
DobleСomplArr(vc, -100, 100); // Заполняем массив
RoundingDoble(vc, 2);         // Округяем числа массива
DobleSearch(vc);              // Ищем макс. и мин. число в массиве и выводим их



//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Задача 41");
Console.WriteLine($"Ввести размер массива");
int r =  Convert.ToInt32(Console.ReadLine());
int[] mass = CrtArr(r);
ManuallyNumbersArray(mass);
Console.WriteLine($"Колличество положительных чисел = {SearchingNumberArray(mass)}");


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Задача 43");
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

DeterminingPointCoordinates(k1, k2, b1, b2);


//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] a = new double[3, 4];
CrtTwoDimRealArr(a);


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] s = CrtTwoDimArr(3, 4);
FillTwoDimArr(s);
PrintTwoDimArr(s);
Console.Write($"Введите координаты числа по X - ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите координаты числа по Y - ");
int y = Convert.ToInt32(Console.ReadLine());
SearchingElementCoordinates(s, x, y);


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] f = CrtTwoDimArr(3, 4);
FillTwoDimArr(f);
PrintTwoDimArr(f);
ArithmeticMeanArray(f);
*/

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] mass = CrtTwoDimArr(5, 5);
FillTwoDimArr(mass);
PrintTwoDimArr(mass);
//Упорядочивал как и в одномерном массиве. Для этого потредовалось использовать 3и вложенных цикла
for (int i = 0; i < mass.GetLength(0); i++) //Происходит движение по строка
{
    for (int j = 0; j < mass.GetLength(1); j++) //Происходит движение по столбцам. А точнее - предыдущий цикл стартует с первой строки массива
    {                                           //В свою очередь второй цикл пробегает по этой строке по всем элементам.
        for (int k = 0; k < mass.GetLength(1) - 1; k++) // В условии стоит -1 для того чтобы не выйти за пределы строки которую сортируем
        {
            if (mass[i, k] < mass[i, k + 1])    // К + 1 потому что мы сравниваем первое число со следующим по порядку.
            {   
                int t = mass[i, k + 1];         // Добавляем перпенную Т и назначаем ей число которое находится ячейки К + 1. 
                mass[i, k + 1] = mass[i, k];    // Теперь присваем ячейки К + 1 значение которое хрониться в ячейке К
                mass[i, k] = t;                 // Назначем ячейки К число которое присвоено переменной Т
            }
        }
    }
}
// Цикл со счётчиком К нужен потому, что мы не можем за один проход сортануть все числа по порядку.
// Поэтому приходиться пробегать по одной строке столько раз сколько числе в строке.
// Условие внутри выполняет перемещение значений ячеек массива. 
// - Если 0 элемент строки < 1 элемента строки, то значение 1ой ячейки присваем переменной Т, затем значение 0ой ячейчи перемещаем в 1ую ячейку
// - - после присваем значение переменной Т к 0ой ячейке.
Console.WriteLine();
PrintTwoDimArr(mass);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] a = CrtTwoDimArr(5, 4);
FillTwoDimArr(a);
PrintTwoDimArr(a);
Console.WriteLine();
int[] s = CrtArr(5);
int p = 0;
int r = int.MaxValue;
int indexMin = 0;
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        p += a[i, j];
    }
    Console.Write($"{p} ");
    if (p < r)
    {
        r = p;
        indexMin = i + 1;
    }
    p = 0;
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(indexMin);
