// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) );
}

Console.WriteLine("Enter X-coordinate: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Y-coordinate: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Z-coordinate: ");
double z1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter X-coordinate: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Y-coordinate: ");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Z-coordinate: ");
double z2 = double.Parse(Console.ReadLine()!);

double result = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(result, 2));