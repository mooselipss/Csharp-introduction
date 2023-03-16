// Задача 3: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fib(int n)
{
    int first = 0;
    int second = 1;
    for (int i = 0; i < n; i++)
    {
        Console.Write(first + " ");
        (first, second) = (second, first + second);
    }
}

Fib(7);