// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter first number: ");
double FirstNumber = double.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
double SecondNumber = double.Parse(Console.ReadLine()!);
if (FirstNumber > SecondNumber)
{
    Console.WriteLine($"Max = {FirstNumber}");
}
else if (FirstNumber == SecondNumber)
{
    Console.WriteLine("The numbers are equal");
}
else
{
    Console.WriteLine($"Max = {SecondNumber}");
}