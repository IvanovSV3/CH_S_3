// 20. Ввести номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Веедите номер четверти №1; №2; №3; №4");
string s = Console.ReadLine();
 double x;
x = Convert.ToInt32(s);

if (x == 2) Console.WriteLine("Значение координат x < 0 & Y > 0");
if (x == 1) Console.WriteLine("Значение координат x > 0 & Y > 0");
if (x == 3) Console.WriteLine("Значение координат x < 0 & Y < 0");
if (x == 4) Console.WriteLine("Значение координат x > 0 & Y < 0");