// 2. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

int Factorial(int number)
{
    int fact = 1;

    for (int i = 1; i <= number; i++)
    {
        fact *= i;
    }
    return fact;
}

Console.WriteLine("Enter your number: ");
int num = int.Parse(Console.ReadLine()!);
int result = Factorial(num);
Console.WriteLine(result);