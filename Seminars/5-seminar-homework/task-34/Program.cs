// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

void EvenNum(int[] array)
{
    int even = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even += 1;
        }
    }
    Console.WriteLine($"Amount even numbers in this array — {even}");
}


// Проверка на корректный ввод значений с помощью бесконечного цикла. Реализовал сам, без интернетов) Честно!)
while (true)
{
    Console.WriteLine("Enter array size from 1: ");
    int array_size = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter start number from 100 to 1000 : ");
    int start_num = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter end number from 100 to 1000 : ");
    int end_num = int.Parse(Console.ReadLine()!);

    if (array_size > 0 && start_num >= 100 && start_num < 1000 && end_num >= 100 && end_num <= 1000)
    {
        int[] arr = FillArray(array_size, start_num, end_num);
        Print(arr);
        EvenNum(arr);
        break;
    }
    else
    {
        Console.WriteLine("Invalid value entered for array size, or start num, or end num.");
        Console.WriteLine("Please try again)");

    }


}


