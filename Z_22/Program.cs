// 22. Найти расстояние между точками в пространстве 2D/3D
Random temp = new Random();
// int X1 = temp.Next(-10,11);
// int X2 = temp.Next(-10,11);
// int Y1 = temp.Next(-10,11);
// int Y2 = temp.Next(-10,11);
// int Z1 = temp.Next(-10,11);
// int Z2 = temp.Next(-10,11);

int[] kordinat = new int[6];
// [X1 Y1 Z1 X2 Y2 Z2]

for (int i = 0; i < 6; i++)
{
    kordinat[i] = temp.Next(-10,11);
    Console.Write(kordinat[i] +"  ");
}

double X2D = kordinat[0] - kordinat[3];
double Y2D = kordinat[1] - kordinat[4];
double Z2D = kordinat[2] - kordinat[5];

Console.WriteLine("  X2D =  " +X2D);

double qx = Math.Pow(X2D,2);
double qy = Math.Pow(Y2D,2);
double qz = Math.Pow(Z2D,2);

double L2D = Math.Sqrt(qx + qy);
double L3D = Math.Sqrt(L2D + qz);

Console.WriteLine("Растояние в 2D =  " +Math.Round(L2D));
Console.WriteLine("Растояние в 3D =  " +Math.Round(L3D));

