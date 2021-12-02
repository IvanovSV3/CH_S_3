// 72 Написать программу возведения числа А в целую стень B
Random nemmber = new Random();
int A = nemmber.Next(2,6);
int B = nemmber.Next(2,6);
Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine();
int P = 1;

void Degree(int a, int b, int p)
{
    if (b > 1)
    {
        p = p * a;
        b = b - 1;
        Degree(a,b,p);
    }
    else
    {
        Console.WriteLine("А в степени В = "+p);
    }
}
Degree(A,B,A);