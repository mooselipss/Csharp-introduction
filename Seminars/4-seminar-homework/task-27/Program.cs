// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigitInNumber(int number)
{
    int lastDigit= 0;
    int sumLastDigits = 0;

    for (int i = 0; number > 0; i++)
    {
        lastDigit= number % 10;
        sumLastDigits += lastDigit;
        number = number / 10;
    }
    
    return sumLastDigits;
}

Console.WriteLine("Enter your number: ");
int num = int.Parse(Console.ReadLine()!);
int result = SumDigitInNumber(num);
Console.WriteLine(result);