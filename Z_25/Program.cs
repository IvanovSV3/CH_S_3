// 25. Найти сумму чисел от 1 до А
Console.WriteLine("Ведите целое число А");
string a = Console.ReadLine();
int A;
int Summa = 0;
int index = 1;
A = Convert.ToInt32(a);
// Console.WriteLine(A);

while (index <= A)
{
     Summa = Summa + index;
     index = index + 1;
}
Console.WriteLine("Сумма чисел:");
Console.WriteLine(Summa);