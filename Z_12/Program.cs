// 12. Удалить вторую цифру трёхзначного числа
Random ser = new Random();
int number = ser.Next(100,1000);
Console.WriteLine(number);

int numb1 = number /10/10%10;
int numb2 = number /10%10;
int numb3 = number %10;
Console.WriteLine(numb1);

number = numb1 * 10 + numb3;

Console.WriteLine("без второй цифры " +number);

// string numberstrit = Convert.ToString(number);
// char[] numbermasiv = numberstrit.ToCharArray();
// Console.WriteLine(numbermasiv[0]);
// Console.WriteLine(numbermasiv[1]);
// Console.WriteLine(numbermasiv[2]);

// int[] numbernew = new[2];