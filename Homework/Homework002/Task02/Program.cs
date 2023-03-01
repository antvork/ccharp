int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetNumber("Введите число: ");

while (number > 1000)
{
    number = number / 10;
}
int a = number / 100;
if (a == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int result = number % 10;
    Console.WriteLine(result);
}
