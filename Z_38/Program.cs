// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int H=4;
int[] ser = new int[H];
double k;
int Sum=0;


for (int i = 0; i < ser.Length; i++)
{
    ser[i] = new Random().Next(0,100);
    Console.Write(ser[i] + " ");
    
    k = i%2;
    if (k == 0)
    {
       Sum = Sum + ser[i];
    }
}
Console.WriteLine("Сумма = " +Sum);