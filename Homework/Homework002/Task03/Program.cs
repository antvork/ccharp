int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

string GetWekendDay(int nDay)
{
    string output = ("Не верное число");
    if (nDay <= 7 && nDay > 0)
    {
        if (nDay > 5)
        {
            output = ("Да");
        }
        else
            output = ("Нет");
    }
    return output;
}

int day = GetNumber("Введите число дня недели: ");
string result = GetWekendDay(day);



Console.WriteLine(result);