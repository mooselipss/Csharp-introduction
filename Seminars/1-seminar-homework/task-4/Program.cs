// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter first number: ");
double FirstNumber = double.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
double SecondNumber = double.Parse(Console.ReadLine()!);
Console.Write("Enter third number: ");
double ThirdNumber = double.Parse(Console.ReadLine()!);
double max = FirstNumber;
if (SecondNumber > max)
{
    max = SecondNumber;
}
if (ThirdNumber > max)
{
    max = ThirdNumber;
}
Console.WriteLine(max);