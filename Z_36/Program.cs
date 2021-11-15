// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] serg = new int[10];
int k1 = 0; 
int k2 = 0;
double k;

for (int i = 0; i < serg.Length; i++)
{
    serg[i]= new Random().Next(100,999);
    Console.Write(serg[i] + " ");
    k = serg[i]%2;
    if (k == 0)
    {
        k1 = k1+1;
    }
    else
    {
        k2 = k2+1;
    }
}
Console.WriteLine("Количество четных " + k1);
Console.WriteLine("Количество не четных " + k2);