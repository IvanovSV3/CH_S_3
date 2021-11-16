// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool X = false;
bool X1 = true;

bool Y = false;
bool Y1 = true;

bool f1 = !(X || Y);
bool f2 = !X && !Y;

Console.WriteLine(f1);
Console.WriteLine(f2);
