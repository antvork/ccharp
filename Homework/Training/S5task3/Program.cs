// Задача 3
// Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101 3 -> 11 2 -> 10

int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetNumber("Введите число: ");

static string DecToBin(int n)
{
    if (n == 0)    //базовый сценарий - выход из рекурсии 
        return "0";
    if (n / 2 > 0)
        return DecToBin(n / 2) + (char)(n % 2 + '0');
    else
        return ""+ (char)(n % 2 + '0');
}
Console.WriteLine(DecToBin(num));

