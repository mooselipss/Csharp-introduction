// Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.

int MaxNumber(int number)
{
    Console.WriteLine(number);
    int num1 = number / 10;
    int num2 = number % 10;
    if(num1 > num2) return num1;
    return num2;
}

int result = MaxNumber(new Random(). Next(10,100));
Console.WriteLine(result);