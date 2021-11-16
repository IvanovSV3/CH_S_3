// 28. Подсчитать сумму цифр в числе
Random temp = new Random();
int number = temp.Next(100,1000);
Console.WriteLine(number);
int num1 = number %10; Console.WriteLine(num1);
int num2 = number /10%10; Console.WriteLine(num2);
int num3 = number /10/10%10; Console.WriteLine(num3);

int sum = num1 + num2 + num3;
Console.WriteLine("Сумма цифр в числе = " +sum);
