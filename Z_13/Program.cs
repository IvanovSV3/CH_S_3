// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
int disit = 4;
Random numb = new Random();
int number = numb.Next(10, 100);
Console.WriteLine(number);

int residue = number % disit;
if (residue == 0)
{
    Console.WriteLine("Число кратно заданому");
}
else
{
    Console.WriteLine("Число не кратно заданому, остаток = " + residue);
}