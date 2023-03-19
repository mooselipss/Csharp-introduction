// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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

string SearchElement(int[,] array, int line, int pillar)
{
    int rowLimit = array.GetLength(0);
    int columnLimit = array.GetLength(1);

    if (line <= rowLimit && pillar <= columnLimit)
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i + 1 == line && j + 1 == pillar)
                    return $"Searching element –> {array[i, j]}";
            }
        }
    return "There is no such number in the array";

}

Console.WriteLine("Enter number rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number columns: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter start number : ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter end number: ");
int end = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter row number searching element: ");
int rowPos = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter column number searching element: ");
int columnPos = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] array = FillArray(rows, columns, start, end);
PrintArray(array);
Console.WriteLine();
string searchingElement = SearchElement(array, rowPos, columnPos);
Console.WriteLine(searchingElement);