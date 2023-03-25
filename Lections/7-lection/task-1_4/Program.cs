// вычислить а в натуральной степени n

// итеративный способ
// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// int pow = PowerFor(2, 3);
// Console.WriteLine(pow);

// рекурсивный способ

// int PowerFor(int a, int n)
// {
//     if (n == 0) return 1;
//     else return a * PowerFor(a, n - 1);
// }

// int pow = PowerFor(2, 10);
// Console.WriteLine(pow);

int PowerFor(int a, int n)
{
    if (n == 0) return 1;
    else if(n % 2 == 0) return PowerFor(a * a, n / 2);
    else return a * PowerFor(a, n - 1);
}

int pow = PowerFor(2, 10);
Console.WriteLine(pow);