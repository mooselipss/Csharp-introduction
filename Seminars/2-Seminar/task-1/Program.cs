// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.

int Take3number(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

int result = Take3number(new Random().Next(100, 1000));
Console.WriteLine(result);
//int number = new Random().Next(100, 1000);
