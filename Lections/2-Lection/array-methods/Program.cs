void FillArray(int[] numbers)
{
    int lenght = numbers.Length;
    int index = 0;
    while (index < lenght)
    {
        numbers[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] num)
{
    int count = num.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(num[position]);
        position++;
    }
}
int IndexOf(int[] numbers, int find)
{
    int lenght = numbers.Length;
    int index = 0;
    int position = -1;
    while (index < lenght)
    {
        if (numbers[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];
int find = 55;

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, find);
Console.WriteLine(pos);