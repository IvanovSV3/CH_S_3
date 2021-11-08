// Задача 15 Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Ведите целое число ");
string s = Console.ReadLine();
double a = Convert.ToInt32(s);
//int f = Int32.Parse(s);
//Console.WriteLine(f);
// double d = Math.Round(a);
// Console.WriteLine(d);

double d = a % 7;
double d1 = a % 23;

if (d == 0)
{
    Console.WriteLine("Число кратно 7");
}
else
{
    if (d1 == 0)
{
  Console.WriteLine("Число кратно 23");  
}

}

if (d > 0 && d1 > 0)
{
    Console.WriteLine("Число не кратно 23 и 7"); 
}







// Семинар СШ 03 (04-11-21) Задача 1
// int a = 6;
// Console.WriteLine("Веедите число");
// string s = Console.ReadLine();
// a = Convert.ToInt32(s);
// Console.WriteLine("Квадрат числа = ");
// Console.WriteLine(Math.Pow(a,2));