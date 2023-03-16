// Задача 2: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string ConvertBin(int number)
{
    string result = string.Empty;

    while (number > 0)
    {
        result = number % 2 + result;
        number = number / 2;
    }
    return result;
}

Console.WriteLine("Enter your number: ");
int num = int.Parse(Console.ReadLine()!);
string bin_num = ConvertBin(num);
Console.WriteLine(bin_num);