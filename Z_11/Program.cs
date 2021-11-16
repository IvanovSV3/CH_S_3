// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Random ser = new Random();
int digit = ser.Next(10,100);
Console.WriteLine(digit);

int number1, number2;

number1 = digit % 10;
Console.WriteLine("Число 1 " +number1);
number2 = digit /10 %10;
Console.WriteLine("Число 2 " +number2);

if (number1 > number2)
{
    Console.WriteLine("Наибольшая цифра " +number1);
}
else
{
    Console.WriteLine("Наибольшая цифра " +number2);
}