// 48 Показать двумерный массив размером m×n заполненный целыми числами

int n = 4, m = 6;
int[,] АrrayDu = new int[n,m];
Random chance = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        АrrayDu[i,j] = chance.Next(0,101);
        Console.Write(АrrayDu[i,j]+" ");
    }
Console.WriteLine();
}
