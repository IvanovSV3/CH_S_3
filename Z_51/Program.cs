// 51 Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] ArrayAmn = new int[4,7];

int[,] ArrayCreate(int[,] arraytemp)
{
// Random chance = new Random();

for (int i = 0; i < arraytemp.GetLength(0); i++)
{
    for (int j = 0; j < arraytemp.GetLength(1); j++)
    {
        arraytemp[i,j] = i + j;
    }
}
return arraytemp;
}

void ArrayPrint(int[,] arraytemp1)
{
for (int i = 0; i < arraytemp1.GetLength(0); i++)
{
    for (int j = 0; j < arraytemp1.GetLength(1); j++)
    {
        Console.Write(arraytemp1[i,j]+" ");
    }
    Console.WriteLine();
    }
}

ArrayAmn = ArrayCreate(ArrayAmn);

ArrayPrint(ArrayAmn);