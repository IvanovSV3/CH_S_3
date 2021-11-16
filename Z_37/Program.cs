// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Random temp = new Random();
int[] masiv = new int[123];

for (int i = 0; i < masiv.Length; i++)
{
    masiv[i] = temp.Next(1,500);
    // Console.Write(masiv[i] +"  ");

     if (masiv[i] < 99)
     {
        if (masiv[i] > 10)
         {
            Console.WriteLine("Пренадлежит заданному отрзку " +masiv[i]+ "  "); 
        }
    }
}