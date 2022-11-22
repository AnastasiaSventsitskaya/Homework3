// Напишите программу, которая принимает на вход кардинаты двух точек и находит расстояние между ними в 3D


Console.WriteLine("write X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2) );

Console.WriteLine(result);

