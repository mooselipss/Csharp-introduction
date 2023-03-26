// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

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

string PrintArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];
        // если элемент не последний, то добавляю табуляцию
        if (i != array.Length - 1)
            result += "\t";
        // если элмент последний, то перехожу на новую строку
        else
            result += "\n";
    }
    return result;
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

int[] SumOfRows(int[,] array, int rows)
{
    int[] sumOfRows = new int[rows];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfRows[i] += array[i, j];
        }
    }
    return sumOfRows;
}

void RowWithsmallestSum(int[] array)
{
   int minElement = array[0];
   int minPos = 0;
   for (int i = 0; i < array.Length; i++)
   {
        if(minElement > array[i])
        {
            minElement = array[i];
            minPos = i;
        }
   }
   Console.WriteLine(minPos + 1);
}


int row = UserInput("Enter number of rows: ");
int column = UserInput("Enter number of columns: ");
int startNumber = UserInput("Enter start number: ");
int endNumber = UserInput("Enter end number: ");
Console.WriteLine();

int[,] arrayForcompare = Create2dArray(row, column);
Fill2dArray(arrayForcompare, startNumber, endNumber);
string fillingArray = Print2dArray(arrayForcompare);
Console.WriteLine(fillingArray);
Console.WriteLine();

int[] sumArr = SumOfRows(arrayForcompare, row);
string resSum = PrintArray(sumArr);
Console.WriteLine(resSum);
RowWithsmallestSum(sumArr);



