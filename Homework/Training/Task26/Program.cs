//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumQantNum(int num)
{
    int i = 0;
    while (num > 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}

int z = GetNumber("Введите число: ");
int x = 0;
if (z == 0)
{
    Console.WriteLine("Количество чифр в числе: 1");
}
else
{
    x = GetSumQantNum(z);
    Console.WriteLine("Количество чифр в числе: " + x);
}


