// Семинар СШ 03 (04-11-21) Задача 1
int a = 6;
Console.WriteLine("Веедите число");
string s = Console.ReadLine();
a = Convert.ToInt32(s);
Console.WriteLine("Квадрат числа = ");
Console.WriteLine(Math.Pow(a,2));