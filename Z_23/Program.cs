﻿//23. Показать таблицу квадратов чисел от 1 до N 
Console.WriteLine("Введите чило элементов N");
string n = Console.ReadLine();
int N = Convert.ToInt32(n);
// Console.WriteLine(N);

int[] tabl = new int[N];
int index = 0;
double index_1 = 1;

while (index < N)
{    
    //  tabl[index] = index + 2;
     tabl[index] = Convert.ToInt32(Math.Pow(index_1,2));
     Console.WriteLine(tabl[index]);
     index = index + 1;
     index_1++;

}


    //  tabl[index] = Convert.ToInt32(Math.Pow(index_1,2));
    //  index++;
    //  index_1++;
    //  Console.WriteLine(tabl[index]);