// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void GetEvenNumber(int start, int end)
{
    if (end == 0) return;
    else if (end % 2 != 0)
    end -= 1;
    GetEvenNumber(start, end - 2);
    Console.Write($"{end} \t");

}
int start = 1;
int end = 7;
GetEvenNumber(start, end);