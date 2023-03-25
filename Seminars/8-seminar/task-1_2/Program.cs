// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int UserInput(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2dArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2dArray(int[,] array, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(maxValue + 1);
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

int[] Frequency(int[,] array, int maxValue)
{
    int[] dict = new int[maxValue + 1];

    foreach (int element in array)
    {
        dict[element] += 1;
    }
    return dict;
}

string PrintFrequency(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"Число {i} встречается {array[i]} раз \n";
    }
    return result;
}

int row = UserInput("Enter number of rows: ");
int column = UserInput("Enter number of columns: ");
int endNumber = UserInput("Enter end number: ");
Console.WriteLine();

int[,] arrayForChange = Create2dArray(row, column);
Fill2dArray(arrayForChange, endNumber);
string fillingArray = Print2dArray(arrayForChange);
Console.WriteLine(fillingArray);
Console.WriteLine();

int[] dictionary = Frequency(arrayForChange, endNumber);
string result = PrintFrequency(dictionary);
Console.WriteLine(result);