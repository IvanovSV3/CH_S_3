// 5. Написать программу вычисления значения функции y=f(a)
Console.WriteLine("Введите целое число ");
int K1 = Convert.ToInt32(Console.ReadLine());

int ser(int a)
{
    int y;
    y = a + 2*a;
    return y;
}

Console.WriteLine("значение фукции " +ser(K1));