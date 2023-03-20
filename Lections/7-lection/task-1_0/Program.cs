// Соберите строку с числами от А до Б, А <= Б.

// string NumbersFor(int a, int b)
// {
//     string result = string.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

string NumbersRecursion(int a, int b)
{
    if(a <= b) return $"{a} " + NumbersRecursion(a + 1, b);
    else return string.Empty;
}


Console.WriteLine("Enter number a: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number b: ");
int numberB = int.Parse(Console.ReadLine()!);

string res = NumbersRecursion(numberA, numberB);
Console.WriteLine(res);