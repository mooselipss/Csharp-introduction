// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] FillArray(int size, double from, double to)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * (to - from) + from;
        array[i] = Math.Round(array[i], 5);
    }
    return array;
}

void Print(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double SearchMin(double[] array)
{

    double min_element = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min_element)
        {
            min_element = array[i];
        }
    }
    return min_element;
}

double SearchMax(double[] array)
{
    double max_element = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max_element)
        {
            max_element = array[i];
        }
    }
    return max_element;
}

double Difference(double min, double max)
{
    double result = max - min;
    return Math.Round(result, 5);
}

while (true)
{
    Console.WriteLine("Enter array size from 1: ");
    int array_size = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter start number : ");
    double start_num = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter end number : ");
    double end_num = double.Parse(Console.ReadLine()!);
    if (array_size > 0)
    {
        double[] arr = FillArray(array_size, start_num, end_num);
        Print(arr);

        double min_value = SearchMin(arr);
        double max_value = SearchMax(arr);
        double diff = Difference(min_value, max_value);
        Console.WriteLine($"Max element = {max_value}");
        Console.WriteLine($"Min element = {min_value}");
        Console.WriteLine($"Difference = {diff}");
        break;
    }
    else
    {
        Console.WriteLine("Invalid value entered for array size.");
        Console.WriteLine("Please try again)");
    }
}
