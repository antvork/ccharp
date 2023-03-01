int GetNumber (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int c = GetNumber("Введите число: ");