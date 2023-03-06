// // 1 тип. Ничего не принимает и ничего не возвращает.
// void Method1()
// {
//     Console.WriteLine("Author - Alex Makarov");
// }

// //Method1();

// // 2 Тип. Что то принимает, но ничего не возвращает.

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2("Text of message");

// // 2 Тип метода. Именованные аргументы (если метод принимает несколько аргументов)
// // Именованные аргументы можно указывать не по порядку

// void Method2_1(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method2_1("Text ", 4);
// // Method2_1(count: 2, msg: "Text");

// // 3 Тип. Что то возвращают, но ничего не принимают.
// // Для методов, которые что то возвращают, обязательно использование оператора return

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// // Console.WriteLine(year);

// // 4 Тип. Что то принимают и что то возвращают.

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res =  Method4(3,"r ");
// Console.WriteLine(res);