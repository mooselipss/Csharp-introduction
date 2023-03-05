//Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да
void Divide7And23(int number)
{
    if(number % 7 == 0 && number % 23 ==0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine()!);
Divide7And23(number);