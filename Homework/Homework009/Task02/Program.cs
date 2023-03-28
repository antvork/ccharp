//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumFromMtoN(int m, int n)
{
    int sum = 0;
    if (m > n)
    {
        if (m == n) return sum = sum + m;
        else return sum = m + SumFromMtoN(m - 1, n);
    }
    else
    {
        if (n == m) return sum = sum + n;
        else return sum = n + SumFromMtoN(m, n - 1);
    }
}

int m = GetNumber("Задайте значение M: ");
int n = GetNumber("Задайте значение N: ");
int result = SumFromMtoN(m, n);
Console.WriteLine(result);