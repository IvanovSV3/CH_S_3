﻿// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Веедите координату Х");
string s = Console.ReadLine();
double x;
x = Convert.ToInt32(s);

Console.WriteLine("Веедите координату Y");
string s1 = Console.ReadLine();
double Y;
Y = Convert.ToInt32(s1);

if (x > 0 & Y > 0) Console.WriteLine("Четверь № 1");
if (x < 0 & Y > 0) Console.WriteLine("Четверь № 2");
if (x < 0 & Y < 0) Console.WriteLine("Четверь № 3");
if (x > 0 & Y < 0) Console.WriteLine("Четверь № 2");



// int a = 6;
// Console.WriteLine("Веедите число");
// string s = Console.ReadLine();
// a = Convert.ToInt32(s);
// Console.WriteLine("Квадрат числа = ");
// Console.WriteLine(Math.Pow(a,2));

