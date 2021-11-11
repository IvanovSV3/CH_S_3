//9. Показать четные числа от 1 до N

int a, index;
Console.WriteLine("Веедите число");
string s = Console.ReadLine();
a = Convert.ToInt32(s);
double b = a % 2;
index = 1;
 

while (index <= a)
{
    b = index%2;
    
    if (b == 0)
    {
        Console.WriteLine(index);
    }
    index = index + 1;
}
