// 69 Найти сумму элементов от M до N, N и M заданы
Random number = new Random();
int M = number.Next(1,5);
int N = number.Next(10, 15);
Console.WriteLine("Число М = "+M);
Console.WriteLine("Число N = "+N);

void SummNumber(int m, int n, int summ)
{
    if (m < n)
    {
       summ = summ + m;
       m = m + 1; 
       SummNumber(m, n, summ);
    }
    else
    {
    Console.WriteLine("Cумма = "+summ); 
    }
}

SummNumber(M, N, 0);