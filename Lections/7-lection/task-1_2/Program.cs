// Найти сумму числел от 1 до N

// Итеративный способ


// int SummOfNum(int n)
// {
//     int sum = 0;
//     for (int i = 1; i <= n; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// int sum = SummOfNum(5);
// Console.WriteLine(sum);

// Рекусивный способ

int SummOfNum(int n)
{
    if(n == 0) return 0;
    else return n + SummOfNum(n - 1);
}
int sum = SummOfNum(5);
Console.WriteLine(sum);