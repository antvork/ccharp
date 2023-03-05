// Вид 1 (ничего не принимает ничего не возвращает)
void Method1()
{
    Console.WriteLine("Автор ...");
}

//Method1();

// Вид 2 (Чтото принимает, ничего не возвращает)

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
//Method21(msg: "Текст",count: 4); //Именование аргументов в методе
//Method21(count: 4, msg: "Текст");
//Вид 3 (Ничего не принимает, что то возвращает)
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//Вид 4 (Чтото принимает, что то  возвращает)

//string Method4(int count, string text)
//{
//    int i =0;
//    string result = String.Empty;
//    while(i<count)
//    {
//        result = result+ text;
//        i++;
//    }
//    return result;
//}
//string res = Method4(10, "asdf");
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
string res = Method4(10, "asdf");
//Console.WriteLine(res);

for (int a = 2; a <= 10; a++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{a} x {j} = {a * j}"); //Интерполяция строк
    }
    Console.WriteLine();
}
