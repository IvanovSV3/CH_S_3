// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно 
// сумме двух предыдущих. Первые два элемента последовательности задаются пользователем/
int N = 10;
Console.WriteLine("Ведите перый элемент");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второй элемент");
int n2 = Convert.ToInt32(Console.ReadLine());

void ShowNummber(int a, int b, int n)
{
int c;
if (n > 0)
{
    c =  a + b;
    a = b;
    b = c;
    Console.WriteLine(c);
    n = n - 1;
    ShowNummber(a, b, n);
}
}
ShowNummber(n1, n2, N);