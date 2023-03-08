// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

void Quarter(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console.WriteLine("Incorrect input, X or Y equal 0. Try again");
    }
    else if (x > 0 && y > 0)
    {
        Console.WriteLine("I");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("II");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("III");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("IV");
    }
}

Console.WriteLine("Enter X");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Y");
int y = int.Parse(Console.ReadLine()!);
Quarter(x, y);