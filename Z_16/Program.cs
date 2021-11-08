// Задача 16 Дано число обозначающее день недели. Выяснить является номер недели выходным днём
Console.WriteLine("Ведите целое число обозначающее день недели от 1 до 7 ");
string s = Console.ReadLine();
int a = Convert.ToInt32(s);


if (a == 6 ^ a == 7)
{
    Console.WriteLine("Данный день недели выходной");
}
else
{
    Console.WriteLine("Данный день не недели выходной");
}
