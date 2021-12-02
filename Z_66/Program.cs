// 66 Показать натуральные числа от 1 до N, N задано
Random ser = new Random();
int N = ser.Next(0,15);
Console.WriteLine("N = "+N);
int k = 0;

void PrintInt(int n, int k)
{
    
    if (0 <= n)
    {
       Console.WriteLine("Натуральное число = "+ k);
       n = n - 1;
       k = k + 1;
       PrintInt(n,k);
    }
}

PrintInt(N,k);