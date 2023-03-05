int[] numbers = { 31, 62, 43, 74, 25, 96, 47, 18, 25 };

int N = numbers.Length;
int index = 0;
int find = 25;

while (index < N)
{
    if (numbers[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}