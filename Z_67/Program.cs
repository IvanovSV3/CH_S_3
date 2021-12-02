// 67 Показать натуральные числа от N до 1, N задано
Random ser = new Random();
int N = ser.Next(0,15);
Console.WriteLine("N = "+N);

void PrintInt(int n)
{
    if (n >= 0)
    {
       Console.WriteLine("Натуральное число = "+n);
       n = n - 1;
       PrintInt(n);
    }
}
PrintInt(N);