int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int number = GetNumber("Введите число: ");
int result = 0;

if (number > 99 && number < 1000)
{
    result = (number % 100) / 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
