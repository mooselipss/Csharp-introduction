// Напишите программу, которая принимает на вход номер четверти,
// и выдаёт диапазон значений точек X и Y,
void Quarter(int num)
{
    if (num == 1)
    {
        Console.WriteLine("X > 0 and Y > 0");
    }
    else if (num == 2)
    {
        Console.WriteLine("X < 0 and Y > 0");
    }
    else if (num == 3)
    {
        Console.WriteLine("X < 0 and Y < 0");
    }
    else if (num == 4)
    {
        Console.WriteLine("X > 0 and Y < 0");
    }
}

Console.WriteLine("Enter quarter number: ");
int quarterNumber = int.Parse(Console.ReadLine()!);
Quarter(quarterNumber);
