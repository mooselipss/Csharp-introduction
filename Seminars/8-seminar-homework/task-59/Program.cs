// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

string Print2dArray(int[,] array)
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

int[] SearchMinElementPos(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int minElement = array[0, 0];
    int[] posMinElem = new int[2];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minElement)
            {
                minElement = array[i, j];
                minRow = i;
                minColumn = j;
            }
        }

    }
    posMinElem[0] = minRow;
    posMinElem[1] = minColumn;
    return posMinElem;

}

string Print1dArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i] + 1;
        if (i != array.Length - 1)
            result = result + " - row of min element " + "\n";
        else
            result = result + " - column of min element";
    }
    return result;
}

string PrintWithoutRowColMinElem(int[,] array, int[] arr)
{
    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (arr[0] == i || arr[1] == j)
                //continue;
                result += "--";
            else
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


int row = UserInput("Enter number of rows: ");
int column = UserInput("Enter number of columns: ");
int startNumber = UserInput("Enter start number: ");
int endNumber = UserInput("Enter end number: ");
Console.WriteLine();

int[,] array2d = Create2dArray(row, column);
Fill2dArray(array2d, startNumber, endNumber);
string fillingArray = Print2dArray(array2d);
Console.WriteLine(fillingArray);
Console.WriteLine();

int[] minElemPos = SearchMinElementPos(array2d);
string minElemPosRes = Print1dArray(minElemPos);
Console.WriteLine(minElemPosRes);
Console.WriteLine();

string arrayWithoutRowColumn = PrintWithoutRowColMinElem(array2d, minElemPos);
Console.WriteLine(arrayWithoutRowColumn);