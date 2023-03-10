// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// void RandomArray()
// {
//     int[] array = new int [8];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 1000);
//         Console.Write($"{array[i]} ");
//     }
// }

// RandomArray();

// Вариант 2. Более общий случай

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] FillArray(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

Console.WriteLine("Enter array size: ");
int array_size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter start num: ");
int start_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter end num: ");
int end_num = int.Parse(Console.ReadLine()!);

int[] collection = FillArray(array_size, start_num, end_num);
Print(collection);