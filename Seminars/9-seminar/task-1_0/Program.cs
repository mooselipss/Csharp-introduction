// Задача 1: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void NaturalNumInRange(int n)
{
    if(n == 0) return;
    
    NaturalNumInRange(n - 1);
    Console.Write($"{n}, ");
}
int n = 20;
NaturalNumInRange(n);