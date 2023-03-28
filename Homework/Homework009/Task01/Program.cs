// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

string AllNumberN(int n)
{
    string result = String.Empty;
    if (n == 1) return result = result + ($"{1}");
    else return result = ($"{n}, ") + ($"{AllNumberN(n - 1)} ");
}

int number = GetNumber("Введите число: ");
Console.WriteLine(AllNumberN(number));