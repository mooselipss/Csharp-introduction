
void PrintArray(int[] array)
{
    int i = 0;
    int arrLehgth = array.Length;

    while (i < arrLehgth)
    {
        Console.Write($"{array[i]} ");
        i++;
    }
}
void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPos]) minPos = j;
        }
        int temporary = array[i];
        array[i] = array[minPos];
        array[minPos] = temporary;

    }
}
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 100);
    }
}

int[] forSortArray = new int[10];
FillArray(forSortArray);
PrintArray(forSortArray);
SortArray(forSortArray);
Console.WriteLine();
PrintArray(forSortArray);