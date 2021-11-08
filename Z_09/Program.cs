// 9. Показать последнюю цифру трёхзначного числа

int a;
Console.WriteLine("Ведите трех значное число");
string s = Console.ReadLine();
a = Convert.ToInt32(s);


Console.WriteLine("Последняя цифра ");
Console.WriteLine(a%10);

