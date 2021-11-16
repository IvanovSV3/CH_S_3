// 26. Возведите число А в натуральную степень B используя цикл
Random temp = new Random();
int A = temp.Next(1,5);
int B = temp.Next(1,6);
Console.WriteLine("Число A = " +A);
Console.WriteLine("Число B = " +B);


int A1 = A;

for (int i = 2; i <= B; i++)
{
    A1 = A1 *A;
    Console.WriteLine(A1 +"  ");
}