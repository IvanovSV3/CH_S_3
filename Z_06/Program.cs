// 6. Выяснить является ли число чётным
int a = 6;
Console.WriteLine("Веедите число");
string s = Console.ReadLine();
a = Convert.ToInt32(s);
double b = a % 2;
if (b == 0)
{
   Console.WriteLine("число четное"); 
}
else
{
    Console.WriteLine("число не четное"); 
}
