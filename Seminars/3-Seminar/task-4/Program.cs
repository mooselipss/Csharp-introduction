// 3. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

void SquareTable(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{Math.Pow(i,2)} ");
    }
}

SquareTable(5);