// 34. Написать программу замену элементов массива на противоположные
int[] ser = new int[10];
// Console.WriteLine("Ведите чило челое ");
// int a = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < ser.Length; i++)
{
    ser[i] = new Random().Next(-10, 10);
    Console.Write(ser[i] + " ");
    // ser[i] = ser[i] * -1;
    // Console.Write(ser[i] + " ");
}
Console.Write("Новый массив   ");

for (int i = 0; i < ser.Length; i++)
{
    // ser[i] = new Random().Next(-10, 10);
    // Console.Write(ser[i] + " ");
    ser[i] = ser[i] * -1;
    Console.Write(ser[i] + " ");
}