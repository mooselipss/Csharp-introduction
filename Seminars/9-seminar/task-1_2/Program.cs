// Задача 3: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9


int SumNumRec(int num)
{
    if(num == 0) return 0;
    return SumNumRec(num / 10) + num % 10;
}

int number = 453;
int res = SumNumRec(number);
Console.WriteLine(res);
