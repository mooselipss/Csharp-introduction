// Задача 3: Задайте двумерный массив. Найдите сумму элементов
// главной диагонали.
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1+9+2 = 12

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

int SummElementsOfDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array[i, j];
            }

        }

    }
    return sum;

}

Console.WriteLine("Enter number rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number columns: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter start number : ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter end number: ");
int end = int.Parse(Console.ReadLine()!);

int[,] coll = FillArray(rows, columns, start, end);
PrintArray(coll);
Console.WriteLine();
int result = SummElementsOfDiagonal(coll);
Console.WriteLine(result);