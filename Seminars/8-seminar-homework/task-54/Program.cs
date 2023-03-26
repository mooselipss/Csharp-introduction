// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.



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

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i, j] < array[i, k])
                (array[i, j], array[i, k]) = (array[i, k], array[i, j]);
            }
        }
    }
}

int row = UserInput("Enter number of rows: ");
int column = UserInput("Enter number of columns: ");
int startNumber = UserInput("Enter start number: ");
int endNumber = UserInput("Enter end number: ");
Console.WriteLine();

int[,] arrayForSort = Create2dArray(row, column);
Fill2dArray(arrayForSort, startNumber, endNumber);
string fillingArray = PrintArray(arrayForSort);
Console.WriteLine(fillingArray);
Console.WriteLine();
SortArray(arrayForSort);
string sortedArray = PrintArray(arrayForSort);
Console.WriteLine(sortedArray);