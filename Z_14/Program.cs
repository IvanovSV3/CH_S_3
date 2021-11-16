// 14. Найти третью цифру числа или сообщить, что её нет
Random temp = new Random();
int number = temp.Next(1,1000);
Console.WriteLine(number);

if (number / 100 < 1)
{
   Console.Write("Третьей цифры нет");
}
else
{
   number = number % 10;
   Console.Write("Третья цифра = " +number);
}