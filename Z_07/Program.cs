// 7. Показать числа от -N до N

int a;
int b;
int index = 0;
Console.WriteLine("Веедите целое число");
string s = Console.ReadLine();
a = Convert.ToInt32(s);
b = a * -1;

while (b <= a)
{
   Console.WriteLine(b);  
   b = b + 1;
   // index = index +1;
}
