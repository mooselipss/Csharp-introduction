int Max(int num1, int num2, int num3)
{
    int result = num1;
    if (num2 > result) result = num2;
    if (num3 > result) result = num3;
    return result;
}

int[] numbers = { 14, 27, 83, 344, 59, 61, 97, 48, 69 };

int max = Max(Max(numbers[0], numbers[1], numbers[2]), 
              Max(numbers[3], numbers[4], numbers[5]),
              Max(numbers[6], numbers[7], numbers[8]));

Console.WriteLine(max);