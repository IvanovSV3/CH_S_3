// 29. Написать программу вычисления произведения чисел от 1 до N
Random temp = new Random();
int N = temp.Next(2,13);
Console.WriteLine("Число N = " +N);
int multiN = 1;


for (int i = 2; i <= N; i++)
{
   multiN = multiN * i;
   Console.WriteLine("Произведение чисел от 1 до N = " +multiN);
}