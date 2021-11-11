// 27. Определить количество цифр в числе

Console.WriteLine("Веедите целое число");
// string s = Console.ReadLine();
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;

while ( a != 0)
{
     a = a /10;
     b ++;
}
Console.WriteLine("количество чисел");
Console.WriteLine(b);