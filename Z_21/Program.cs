// 21. Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Веедите целое пятизначное число");
string s = Console.ReadLine();
int x, x1, x2, x3, x4;
x = Convert.ToInt32(s);
x1 = x%10;
x2 = x/10%10;
x3 = x/1000%10;
x4 = x/10000%10;
// Console.WriteLine(x4);
if (x1 == x4 & x2 == x3) 
{
    Console.WriteLine("Данное число палиндромом");
}
else
{
  Console.WriteLine("Данное число не палиндромом");  
}




// string s = Console.ReadLine();
// double x;
// x = Convert.ToInt32(s);

// Console.WriteLine("Веедите координату Y");
// string s1 = Console.ReadLine();
// double Y;
// Y = Convert.ToInt32(s1);

// if (x > 0 & Y > 0) Console.WriteLine("Четверь № 1");
// if (x < 0 & Y > 0) Console.WriteLine("Четверь № 2");
// if (x < 0 & Y < 0) Console.WriteLine("Четверь № 3");
// if (x > 0 & Y < 0) Console.WriteLine("Четверь № 2");