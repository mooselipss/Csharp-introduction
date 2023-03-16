// Задача 4: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[,] FillArray(int rows, int columns, int start, int end)
{
    int[,] arr = new int[rows, columns];
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            arr[row, column] = new Random().Next(start, end);
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ArrayCopy(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] copy = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            copy[i,j] = array[i,j];
        }
    }
    return copy;
}

Console.WriteLine("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter start number: ");
int from = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter end number: ");
int to = int.Parse(Console.ReadLine()!);

int[,] array1 = FillArray(rows, columns, from, to);
PrintArray(array1);
int[,] array_cop = ArrayCopy(array1);
PrintArray(array_cop);


