// Вычислите факториал числа используя итеративный и рекусивный способ
// Console.WriteLine(FactorialFor(10)); // 3628800

// итеративный способ
// int Factorial(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         result *= i;
//     }
//     return result;
// }

// int fact = Factorial(10);
// Console.WriteLine(fact);

// рекурсивный способ

int Factorial(int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}
int fact = Factorial(10);
Console.WriteLine(fact);
