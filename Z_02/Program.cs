// 1. По двум заданным числам проверять является ли первое квадратом второго

// Семинар СШ 03 (04-11-21) Задача 1
//int a = 6;
////Console.WriteLine("Веедите число");
//string s = Console.ReadLine();
//a = Convert.ToInt32(s);
//Console.WriteLine("Квадрат числа = ");
//Console.WriteLine(Math.Pow(a,2));

int a = 4;
int b = 17;

Console.WriteLine("Веедите первое число");
string a1 = Console.ReadLine();
a = Convert.ToInt32(a1);

Console.WriteLine("Веедите второе число");
string b1 = Console.ReadLine();
b = Convert.ToInt32(b1);

double ak = Math.Pow(a,2);
//Console.WriteLine(ak);

if (ak == b)
{
    Console.WriteLine("первое квадрат второго");
} 
else
{
    Console.WriteLine("первое не квадрат второго");  
}
Console.WriteLine("Программа завершина");

  


