// 30. Показать кубы чисел, заканчивающихся на четную цифру
Random temp = new Random();
int nuber = temp.Next(1,20);
Console.WriteLine(nuber);
double cube;
double cube2;

for (int i = 1; i <= nuber; i++)
{
   cube = Math.Pow(i, 3);
   Console.WriteLine(cube);
   cube2 = cube % 10 % 2;
   if (cube2 == 0)
   {
       Console.WriteLine("Куб с четным концом = " +cube);
   }
}


