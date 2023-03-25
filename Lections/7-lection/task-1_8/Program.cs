// числа фибоначи методом рекурсии и итеративным методом
// подсчет кол-ва циклов и врмени на выполнение

decimal fibrec = 0;
decimal fibiter = 0;

decimal FibonacciRecursion(int n)
{
    fibrec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fibiter++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
    }
    return result;
}

Console.ReadLine();
DateTime dt = DateTime.Now;

for (int n = 10; n <= 40; n++)
{
    Console.WriteLine($"Fibonacci iteration({n}) = {FibonacciIteration(n)} кол-во циклов = {fibiter}");
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();

Console.ReadLine();
dt = DateTime.Now;

for (int n = 10; n <= 40; n++)
{
    Console.WriteLine($"Fibonacci recursion({n}) = {FibonacciRecursion(n)} кол-во циклов = {fibrec}");
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

