// Задача 4: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int [] Multiply(int [] array)
{
    int size = array.Length;
    int[] new_array = new int[size / 2 + size % 2];
    for (int i = 0; i < size / 2; i++)
    {
        new_array[i] = array[i] * array[array.Length -1 -i];
        if (size % 2 == 1)
        {
            new_array[new_array.Length - 1] = array[array.Length / 2];
        }

    }
    return new_array;

}

Console.WriteLine("Enter array size: ");
int array_size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter start num: ");
int start_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter end num: ");
int end_num = int.Parse(Console.ReadLine()!);

int[] arr = FillArray(array_size, start_num, end_num);
Print(arr);
int [] new_arr = Multiply(arr);
Print(new_arr);