// Задача 4: Задайте двумерный массив. Введите элемент, и найдите
// первое его вхождение, выведите позиции по горизонтали и
// вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

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

string GetPosElement(int[,] array, int find)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == find)
                return $"Введенный элемент {find}, результат: [{i + 1}, {j + 1}]";
        }
    }
    return $"Введенный элемент {find}, результат: такого элемента нет.";

}

Console.WriteLine("Enter number rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number columns: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter start number : ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter end number: ");
int end = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number for search: ");
int searchNum = int.Parse(Console.ReadLine()!);

int[,] coll = FillArray(rows, columns, start, end);
PrintArray(coll);
Console.WriteLine();
string result = GetPosElement(coll, searchNum);
Console.WriteLine(result);

