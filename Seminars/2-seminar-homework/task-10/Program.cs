﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void SecondDigitOfNumber(int ThreeDigitNumber)
{
    int TwoLastDigits = ThreeDigitNumber % 100;
    int SecondDigit = TwoLastDigits / 10;
    Console.WriteLine(SecondDigit);
}

int number = new Random(). Next(100, 1000);
Console.WriteLine(number);
SecondDigitOfNumber(number);