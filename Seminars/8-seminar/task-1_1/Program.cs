// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int UserInput(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2dArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2dArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
}

string PrintArray(int[,] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
            // если элемент не последний, то добавляю табуляцию
            if (j != array.GetLength(1) - 1)
                result += "\t";
            // если элмент последний, то перехожу на новую строку
            else
                result += "\n";
        }
    }
    return result;
}

void SwapStringsOnColumns(int[,] array, int row, int column)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
        }
    }
}
int row = UserInput("Enter number of rows: ");
int column = UserInput("Enter number of columns: ");
int startNumber = UserInput("Enter start number: ");
int endNumber = UserInput("Enter end number: ");
Console.WriteLine();
if (row == column)
{
    int[,] arrayForChange = Create2dArray(row, column);
    Fill2dArray(arrayForChange, startNumber, endNumber);
    string fillingArray = PrintArray(arrayForChange);
    Console.WriteLine(fillingArray);
    Console.WriteLine();
    SwapStringsOnColumns(arrayForChange, row, column);
    string swapingArray = PrintArray(arrayForChange);
    Console.WriteLine(swapingArray);
}
else Console.WriteLine("It is impossible");



