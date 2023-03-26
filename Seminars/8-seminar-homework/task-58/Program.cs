// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    // Проверяем, возможно ли выполнить умножение матриц
    if (matrixA.GetLength(1) != matrixB.GetLength(0)) return resultMatrix;

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}

int rowA = UserInput("Enter number of rows for 1 matrix: ");
int columnA = UserInput("Enter number of columns for 1 matrix: ");
int startNumberA = UserInput("Enter start number for 1 matrix: ");
int endNumberA = UserInput("Enter end number for 1 matrix: ");

int rowB = UserInput("Enter number of rows for 2 matrix: ");
int columnB = UserInput("Enter number of columns for 2 matrix: ");
int startNumberB = UserInput("Enter start number for 2 matrix: ");
int endNumberB = UserInput("Enter end number for 2 matrix: ");
Console.WriteLine();

int[,] matrA = Create2dArray(rowA, columnA);
Fill2dArray(matrA, startNumberA, endNumberA);
string matrixA = Print2dArray(matrA);
Console.WriteLine(matrixA);
Console.WriteLine();

int[,] matrB = Create2dArray(rowB, columnB);
Fill2dArray(matrB, startNumberB, endNumberB);
string matrixB = Print2dArray(matrB);
Console.WriteLine(matrixB);
Console.WriteLine();

int[,] resMatrix = MultiplyMatrices(matrA, matrB);
string resultMatrix = Print2dArray(resMatrix);
Console.WriteLine(resultMatrix);