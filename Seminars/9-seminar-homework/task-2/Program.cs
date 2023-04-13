// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumNum(int start, int end)
{
    if(end == 0) return 0;
    return end + SumNum(start, end - 1);
}

int start = 1;
int end = 17;
int resSum = SumNum(start, end);
Console.WriteLine(resSum);