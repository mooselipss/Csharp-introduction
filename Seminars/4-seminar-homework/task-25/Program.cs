// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Exponentiation(int number1, int number2)
// {
//     int result = 1;
//     for (int i = 1; i <= number2; i++)
//     {
//         result *= number1;
//     }
//     return result;
// }

// Console.WriteLine("Enter number A: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter number B: ");
// int B = int.Parse(Console.ReadLine()!);

// int res =  Exponentiation(A,B);
// Console.WriteLine(res);

//Еще можно сделать так, будет на 1 операцию меньше.

// int Exponentiation(int number1, int number2)
// {
//     int result = number1;
//     for (int i = 1; i < number2; i++)
//     {
//         result *= number1;
//     }
//     return result;
// }


// Решение от преподавателя

double PowNum(int a, int b)
{
    double n_pow = 1;
    int b_abs = Math.Abs(b);

    for (int i = 1; i <= b_abs; i++)
    {
        if (b > 0)
        {
            n_pow *= a;
        }
        else
        {
            n_pow /= a;
        }
    }
    return n_pow;
}

Console.WriteLine("Enter number a: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number b: ");
int b = int.Parse(Console.ReadLine()!);

double result = PowNum(a, b);
Console.WriteLine(result);