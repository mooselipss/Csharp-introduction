// 2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

int [] FillArray(int size, int from, int to)
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

void FindNum(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            Console.WriteLine("Yes");
            return;
        }
    }
    Console.WriteLine("No");
}

Console.WriteLine("Enter array size: ");
int array_size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter start num: ");
int start_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter end num: ");
int end_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter find num: ");
int find_num = int.Parse(Console.ReadLine()!);

int[] coll = FillArray(array_size, start_num, end_num);
Print(coll);
FindNum(coll, find_num);