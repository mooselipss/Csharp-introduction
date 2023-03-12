// 1. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

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

int [] ReplaceElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            array[i] *= -1;
        }
        else
        {
            array[i] = Math.Abs(array[i]);
        }
    }
    return array;
}

Console.WriteLine("Enter array size: ");
int array_size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter start num: ");
int start_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter end num: ");
int end_num = int.Parse(Console.ReadLine()!);

int[] collection = FillArray(array_size, start_num, end_num);
Print(collection);
int[] replace_arr =  ReplaceElements(collection);
Print(collection);