// 3. По заданному номеру дня недели вывести его название
// Семинар СШ 03 (04-11-21) Задача 1
//int a = 6;
//Console.WriteLine("Веедите число");
//string s = Console.ReadLine();
//a = Convert.ToInt32(s);
//Console.WriteLine("Квадрат числа = ");
//Console.WriteLine(Math.Pow(a,2));


string A1 = "пон";
string A2 = "вт";
string A3 = "ср";
string A4 = "чет";
string A5 = "пят";
string A6 = "суб";
string A7 = "вос";

int a;

Console.WriteLine("Веедите число от 1 до 7");
string n = Console.ReadLine();
a = Convert.ToInt32(n);

if (a == 1) 
{
    Console.WriteLine("День недели");
    Console.WriteLine(A1);
}
if (a == 2)
{
    Console.WriteLine("День недели");
    Console.WriteLine(A2);    
}
if (a == 3)
{
    Console.WriteLine("День недели");
    Console.WriteLine(A3);    
}
if (a == 4)
{
    Console.WriteLine("День недели");
    Console.WriteLine(A4);    
}
if (a == 5)
{
    Console.WriteLine("День недели");
    Console.WriteLine(A5);    
}
if (a == 6)
{
    Console.WriteLine("День недели");
    Console.WriteLine(A6);    
}
if (a == 7)
{
    Console.WriteLine("День недели");
    Console.WriteLine(A7);    
}
