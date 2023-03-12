// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0

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

void SumOddPos(int[] array)
{
    int sum_odd = 0;

    for (int i = 0; i < array.Length; i += 2)
    {
        sum_odd += array[i];
    }
    Console.WriteLine(sum_odd);
}

while (true)
{
    Console.WriteLine("Enter array size from 1: ");
    int array_size = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter start number : ");
    int start_num = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter end number : ");
    int end_num = int.Parse(Console.ReadLine()!);
    if (array_size > 0)
    {
        int[] arr = FillArray(array_size, start_num, end_num);
        Print(arr);
        SumOddPos(arr);
        break;
    }
    else
    {
        Console.WriteLine("Invalid value entered for array size.");
        Console.WriteLine("Please try again)");
    }
}