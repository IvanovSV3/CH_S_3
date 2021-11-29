// 50 В двумерном массиве n×k заменить четные элементы на противоположные
// противоположный - умноженный на "-1"
// int n = 3, k = 7;
int[,] array2D = new int[3,7];
Random chance = new Random();

int[,] Arraycreate(int[,] arraytemp)
{
for (int i = 0; i < arraytemp.GetLength(0); i++)
{
    for (int j = 0; j < arraytemp.GetLength(1); j++)
    {
        arraytemp[i,j] = chance.Next(-100,101);
    }
}
return arraytemp; // Как выводить данные?
}


int[,] ArrayPrint(int[,] arraytemp1)
{
    for (int i = 0; i < arraytemp1.GetLength(0); i++)
{
    for (int j = 0; j < arraytemp1.GetLength(1); j++)
    {
        Console.Write($"{arraytemp1[i,j],6}");
    }
    Console.WriteLine();
}
return arraytemp1;
}

int[,] ArrayReplace(int[,] arraytemp2)
{
    for (int i = 0; i < arraytemp2.GetLength(0); i++)
    {
        for (int j = 0; j < arraytemp2.GetLength(1); j++)
        {
            if (arraytemp2[i,j] % 2 == 0)
            {
                arraytemp2[i,j] = arraytemp2[i,j] * -1;
            }
        }
    }
return arraytemp2;
}


array2D = Arraycreate(array2D);
ArrayPrint(array2D);
Console.WriteLine("Измененный масив");
array2D = ArrayReplace(array2D);
ArrayPrint(array2D);
