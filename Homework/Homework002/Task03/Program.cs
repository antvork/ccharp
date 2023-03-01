int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int day = GetNumber("Введите число дня недели: ");
string output = ("Не верное число");

if(day <= 7 && day > 0)
{
    if(day>5)
    {
        output = ("Да");
    }
    else
    output = ("Нет");
}
Console.WriteLine(output);