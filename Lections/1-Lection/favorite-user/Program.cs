﻿Console.WriteLine("Enter your name: ");
string name = Console.ReadLine()!;
if (name.ToLower() == "alex")
{
    Console.WriteLine("Cool bro, you are returned!!!");
}
else
{
    Console.WriteLine($"Hello, {name}");
}