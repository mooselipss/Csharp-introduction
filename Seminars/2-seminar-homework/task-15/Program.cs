// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void DayOfRest(int day)
{
    if (day > 7) Console.WriteLine("Incorrect input, try again");
    else if (day <= 5) Console.WriteLine("No");
    else
    {
        Console.WriteLine("Yes");
    }
}


Console.WriteLine("Enter a number from 1 to 7: ");
int numberOfDay = int.Parse(Console.ReadLine()!);
DayOfRest(numberOfDay);