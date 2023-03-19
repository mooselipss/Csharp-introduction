// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

int[,] FillArray(int lines, int pillars, int from, int to)
{
    int[,] array = new int[lines, pillars];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

void AverageColumn(int[,] array)
{
  double average = 0;
  Console.Write("Average of each column: ");
  for (int i = 0; i < array.GetLength(1); i++)
  {
    for (int j = 0; j < array.GetLength(0); j++)
    {
        average += array[j, i];
    }
    Console.Write($"{Math.Round(average / array.GetLength(0),1)}; ");
    average = 0;
  }
  Console.WriteLine();
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
AverageColumn(coll);

