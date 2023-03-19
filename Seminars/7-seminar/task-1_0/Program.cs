// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
void PrintArray(int[,] array)
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

int[,] FillArray(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

Console.WriteLine("Enter number rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number columns: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter start number : ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter end number: ");
int end = int.Parse(Console.ReadLine()!);

int[,] collection = FillArray(rows, columns, start, end);
PrintArray(collection);
