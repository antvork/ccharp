int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetThreeNum(int number)
{
    while (number > 1000)
    {
         number = number / 10;
    }
    return  number;
}

int ControlThreeNum(int number)
{
    return number / 100;
}

void SearchThirdNum(int number, int a)
{
    if (a == 0)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        int result = number % 10;
        Console.WriteLine(result);
    }
}

int number = GetNumber("Введите число: ");
int number3 = GetThreeNum(number);
int a = ControlThreeNum(number3);
SearchThirdNum(number3, a);



