// Задача 1: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.

void Triangle(int n1, int n2, int n3)
{
    if (n1 < n2 + n3 & n2 < n1 + n3 & n3 < n1 + n2)
    Console.WriteLine("Yes");
    else
    Console.WriteLine("No");
}

Console.WriteLine("Enter 1 number: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter 2 number: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter 3 number: ");
int num3 = int.Parse(Console.ReadLine()!);

Triangle(num1, num2, num3);