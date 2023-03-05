int Max(int num1, int num2, int num3)
{
    int result = num1;
    if (num2 > result) result = num2;
    if (num3 > result) result = num3;
    return result;
}

int a1 = 47;
int b1 = 23;
int c1 = 18;
int a2 = 844;
int b2 = 38;
int c2 = 41;
int a3 = 64586;
int b3 = 17;
int c3 = 93;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);