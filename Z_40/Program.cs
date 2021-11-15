// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] ser = new double[10];
double[] ser_znak = new double[10];
double[] ser_itog = new double[10];
Random dan = new Random();
Random dan_z = new Random();


for (int i = 0; i < ser.Length; i++)
{
    ser[i] = dan.Next(-100,100);
    // Console.Write(ser[i] + " ");
    ser_znak[i] = dan_z.NextDouble();
    // Console.Write(ser_znak[i] + " ");
    ser_itog[i] = ser_znak[i] * ser[i];
    Console.WriteLine(ser_itog[i] + " ");
}
double max = ser_itog[0];
double min = ser_itog[0];

for (int i = 0; i < ser.Length; i++)
{
    if (ser_itog[i] >= max)
    {
        max = ser_itog[i];
    }
    if (ser_itog[i] < min)
    {
        min = ser_itog[i];
    }
}
Console.WriteLine("Макс " +max);
Console.WriteLine("Мин " +min);

double itog = max - min;
Console.WriteLine("Мах - Мин " +itog);