// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome(int number)
{
    int digit1 = number / 10000;
    int digit5 = number % 10;
    int digit2_1 = number / 1000;
    int digit2 = digit2_1 % 10;
    int digit4_1 = number % 100;
    int digit4 = digit4_1 / 10;

    if (digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

Console.WriteLine("Enter 5 digit number: ");
int fiveDigitNum = int.Parse(Console.ReadLine()!);
Palindrome(fiveDigitNum);