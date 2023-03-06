// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

// — Я думаю, — сказал князь, улыбаясь, — что,”
// ”ежели бы вас послали вместо нашего милого Винценгероде,”
// ”вы бы взяли приступом согласие прусского короля.”
// ”Вы так красноречивы. Вы дадите мне чаю?”

string ReplaceChar(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lengthString = text.Length;

    for (int i = 0; i < lengthString; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string testText = "— Я думаю, — сказал князь, улыбаясь, — что,"
                   + "ежели бы вас послали вместо нашего милого Винценгероде,"
                   + "вы бы взяли приступом согласие прусского короля."
                   + "Вы так красноречивы. Вы дадите мне чаю?";

string newText = ReplaceChar(testText, ' ', '|');
Console.WriteLine(newText);
string newText1 = ReplaceChar(newText, 'к', 'К');
Console.WriteLine(newText1);
string newText2 = ReplaceChar(newText1, 'с', 'С');
Console.WriteLine(newText2);
