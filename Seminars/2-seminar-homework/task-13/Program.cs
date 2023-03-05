// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void GetThirdDigit(int number)
{
    if (number < 100) Console.WriteLine("Third digit not found");
    else
    {
        while (number >= 999)
        {
            number = number / 10;

        }
        int result = number % 10;

        Console.WriteLine(result);

    }
}

Console.WriteLine("Enter your number: ");
int num = int.Parse(Console.ReadLine()!);
GetThirdDigit(num);