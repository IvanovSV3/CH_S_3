//  Задачи 2
// №1 Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение всех элементов массива.
// 1.1 сделать метод на заполнение массива fill()
// 1.2 сделать метод сумму sum()
// 1.3 сделать метод произведение multi()



void fill(int[,] serfill)
{   
    for (int i = 0; i < serfill.GetLength(0); i++)
    {
        for (int j = 0; j < serfill.GetLength(1); j++)
        {
            serfill[i,j] = new Random().Next(1, 5);
            Console.Write(serfill[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int sum(int[,] sum_1)
{
    int sumitog = 0;
    for (int i = 0; i < sum_1.GetLength(0); i++)
    {
        for (int j = 0; j < sum_1.GetLength(1); j++)
        {
            sumitog = sumitog + sum_1[i,j];
        }
    }
    return sumitog;
}

double multi(int[,] multi_1)
{
    double multi = 1;
    for (int i = 0; i < multi_1.GetLength(0); i++)
    {
        for (int j = 0; j < multi_1.GetLength(1); j++)
        {
            multi = multi * multi_1[i,j];
        }
    }
    return multi;
}

int[,] serfill_1 = new int[6,8];

fill(serfill_1); //Получили массив наполненный числами
Console.WriteLine(sum(serfill_1) +" - Сумма элементов массива");
Console.WriteLine(multi(serfill_1) +" - Произведение элементов массива");







// Random  ran = new Random();
// int number;
// number = ran.Next(100,1000);
// Console.WriteLine(number);

// serg[i]= new Random().Next(100,999);