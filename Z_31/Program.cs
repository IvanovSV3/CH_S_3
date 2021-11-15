// 31. Задать массив из 8 элементов и вывести их на экран 

int[] ser = new int[8];


for (int i = 0; i < ser.Length; i++)
{
    ser[i] = new Random().Next(1, 20);
    Console.Write(ser[i] + " ");
}