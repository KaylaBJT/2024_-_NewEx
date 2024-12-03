//Вид 1 Методы, которые ничего не принимают и ничегоо не вовзращают
void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();

//Вид 2 Методы, которые ничего не возвращают, но могут принимать аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4);

//Вид 3. Методы, которые ничего не принимают, но что-то возвращают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//Вид 4. Методы, которые что-то принимают и что-то возвращают
//string Method4(int count, string text)
//{
//int i = 0;
//string result = String.Empty;
//
//while (i < count)
//{
//result = result + text;
//i++;
//    }
//return result;
//}
//string res = Method4(10, "я");
//Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "я");
Console.WriteLine(res);