// Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.

int SumNum(int num)
{
    int allSum = 0;
    for (int i = 1; i <= num; i++)
    {
        allSum += i;
    }
    return allSum;
}

Console.WriteLine("Enter your number: ");
int a = int.Parse(Console.ReadLine()!);
int result = SumNum(a);
Console.WriteLine(result);