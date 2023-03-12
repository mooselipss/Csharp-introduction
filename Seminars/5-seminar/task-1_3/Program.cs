// Задача 3: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] FillArray(int size, int from, int to)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, to);
    }
    return array;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int ElementsInRange(int[] array)
{
    int how_many_elements = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            how_many_elements += 1;
        }
        
    }
    return how_many_elements;
}

Console.WriteLine("Enter array size: ");
int array_size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter start num: ");
int start_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter end num: ");
int end_num = int.Parse(Console.ReadLine()!);

int[] coll =  FillArray(array_size, start_num, end_num);
Print(coll);
int elements = ElementsInRange(coll);
Console.WriteLine(elements);
