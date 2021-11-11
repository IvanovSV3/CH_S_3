// 35. Определить, присутствует ли в заданном массиве, некоторое число 
int[] ser = new int[20];
Console.WriteLine("Ведите чило челое ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < ser.Length; i++)
{
    ser[i] = new Random().Next(1, 20);
    Console.Write(ser[i] + "");
} 

for (int i = 0; i < ser.Length; i++)
{
    if (ser[i] == a)
    {
        Console.WriteLine("Найдено совпадение ");
        Console.WriteLine(ser[i]);
    }
}
