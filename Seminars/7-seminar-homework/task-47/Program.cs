// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] FillArray(int lines, int pillars, int from, int to)
{
    double[,] array = new double[lines, pillars];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * (to - from) + from, 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter number rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number columns: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter start number : ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter end number: ");
int end = int.Parse(Console.ReadLine()!);

double[,] twoDimensionalArray = FillArray(rows, columns, start,end);
PrintArray(twoDimensionalArray);