// Получаем информацию о папках и файлах
string path = "/home/alexmakar/dev/Csharp-introduction/Lections/1-Lection/div";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}
