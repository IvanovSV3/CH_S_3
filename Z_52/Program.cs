// 52 В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
// Создать массив шанс. Преобразовать массив. Печатать массив.
int[,] array = new int[6, 9];

int[,] ArrayCreat(int[,] arraytemp1)
{
    Random chance = new Random();
    for (int i = 0; i < arraytemp1.GetLength(0); i++)
    {
        for (int j = 0; j < arraytemp1.GetLength(1); j++)
        {
            arraytemp1[i, j] = chance.Next(0, 10);
        }
    }
    return arraytemp1;
}

void ArrayPrint(int[,] arraytemp2)
{
    for (int i = 0; i < arraytemp2.GetLength(0); i++)
    {
        for (int j = 0; j < arraytemp2.GetLength(1); j++)
        {
            Console.Write($"{arraytemp2[i, j]} ");
            // Console.Write($"{array2D[i,j],10:F4}");
        }
        Console.WriteLine();
    }
}

int[,] IndexSquare(int[,] arraytemp3)
{
    for (int i = 0; i < arraytemp3.GetLength(0); i++)
    {
        
        
         for (int j = 0; j < arraytemp3.GetLength(1); j++)
         {
             if (i % 2 == 0 && j % 2 == 0)
            {
                arraytemp3[i,j] = arraytemp3[i,j] * arraytemp3[i,j];
            }
         }
    
    }
return arraytemp3;
}


array = ArrayCreat(array);
ArrayPrint(array);
array = IndexSquare(array);
Console.WriteLine();
ArrayPrint(array);

