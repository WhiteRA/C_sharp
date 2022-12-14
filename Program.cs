
using System;
using static ConsoleApp.Library;


//Первое ДЗ
/*
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
*/


//Второе ДЗ
/*
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
*/


//Третье ДЗ
/*
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
*/

//Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
