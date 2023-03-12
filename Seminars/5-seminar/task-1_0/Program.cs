// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int [] FillArray(int size, int from, int to)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, to);
    }
    return array;
}

void SumPosNeg(int[] array)
{
    int pos_sum = 0;
    int neg_sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            pos_sum += array[i];
        }
        else
        {
            neg_sum += array[i];
        }
    }
    Console.WriteLine($"Sum of positive numbers = {pos_sum}");
    Console.WriteLine($"Sum of negative numbers = {neg_sum}");
    
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Enter array size: ");
int array_size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter start num: ");
int start_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter end num: ");
int end_num = int.Parse(Console.ReadLine()!);


int[] sum_pos_neg_num = FillArray(array_size, start_num, end_num);
Print(sum_pos_neg_num);
SumPosNeg(sum_pos_neg_num);