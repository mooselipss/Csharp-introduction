// 1. Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

int NumberOfDigits(int number)
{
    
    int howManyDigit = 0;


    for (int i = 1; number > 0; i++)
    {
        number = number / 10;
        //howManyDigit = i;
        howManyDigit++;
    }
    return howManyDigit;
}

Console.WriteLine("Enter your number: ");
int a = int.Parse(Console.ReadLine()!);
int result = NumberOfDigits(a);
Console.WriteLine(result);