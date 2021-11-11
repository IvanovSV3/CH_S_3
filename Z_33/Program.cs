// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива
int[] ser = new int [12];
int sum=0;
int sum1=0;

for (int i = 0; i < ser.Length; i++)
{
    ser[i] = new Random().Next(-9,10);
    Console.WriteLine(ser[i]);
    if (ser[i]>0)
    {
     sum = sum + ser[i];
    }
    else
    {
        sum1 = sum1 + ser[i];
    }
}
Console.WriteLine("Сумма пол. " +sum);
Console.WriteLine("Сумма отр. " +sum1);