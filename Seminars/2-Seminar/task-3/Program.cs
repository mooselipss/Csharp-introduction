// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

void Divide(int number1, int number2)
{
    if (number1 % number2 == 0) Console.WriteLine("Divide");
    else
    {
        Console.WriteLine($"Not divide, remainder {number1 % number2}");
    }
}

Console.WriteLine("Enter first Number: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter second Number: ");
int number2 = int.Parse(Console.ReadLine()!);
Divide(number1,number2);