// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int N;
Console.Write("Ведите размер массива  ");
N = Convert.ToInt32(Console.ReadLine());
int[] ser = new int[N];

int sum1=0;
int sum2=N-1;
int P;

for (int i = 0; i < ser.Length; i++)
{
    ser[i] = new Random().Next(1,100);
    Console.Write(ser[i] + " ");
    
}
for (int i = 0; i < ser.Length; i++)
{
   if (sum2 > sum1)
    {
        P = ser[sum1] * ser[sum2];
        Console.WriteLine("Произведение " + P);
    }
    sum1=sum1+1;
    sum2 = sum2 -1; 
}
