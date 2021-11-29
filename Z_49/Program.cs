// 49 Показать двумерный массив размером m×n заполненный вещественными числами
int  m = 6, n = 9;
double[,] array2D = new double[m,n];
Random chance = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       array2D[i,j] =  chance.NextDouble() * chance.Next(1,100);
    //    Console.Write("{0,10:F4} ", array2D[i,j]);
    Console.Write($"{array2D[i,j],10:F4}");
    }
    Console.WriteLine();
}

// number = rnd.NextDouble();