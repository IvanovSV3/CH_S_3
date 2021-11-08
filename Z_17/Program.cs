// Задача 17 По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Ведите целое число №1 ");
string s = Console.ReadLine();
double a = Convert.ToInt32(s);

Console.WriteLine("Ведите целое число №2 ");
string s1 = Console.ReadLine();
double b = Convert.ToInt32(s1);

double a1 = Math.Pow(a,2);
double b1 = Math.Pow(b,2);


if (a == b1)
{
    Console.WriteLine("Число №2 квадрат числа №1");
}
else
{
    if (b == a1)
{
  Console.WriteLine("Число №1 квадрат числа №2"); 
}

}

if (a == b1 || b == a1)
{
    Console.WriteLine("ВАм повезло с квадратами!!!"); 
}else
{
  Console.WriteLine("Числa №1 и №2 не являются одно квадратом другого");   
}
