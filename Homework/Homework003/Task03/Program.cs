//Напишите метод(-ы), который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
string GetSqrNumber(int number)
{
    double index = 1;
    string result = String.Empty;
    while (index <= number)
    {
        double sqr = Math.Pow(index, 3);
        result = result + "[" + index + "==>" + sqr + "] ";
        index++;
    }
    return result;
}

int n = GetNumber("Введите число: ");
Console.WriteLine(GetSqrNumber(n));

