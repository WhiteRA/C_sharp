
//Первое ДЗ
//Задача 1: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

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


//Задача 2: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

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