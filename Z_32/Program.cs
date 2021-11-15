//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
int[] ser=new int [8];
for (int i = 0; i < ser.Length; i++)
{
    ser[i]=new Random().Next(0,2);
    Console.WriteLine(ser[i]);

}
