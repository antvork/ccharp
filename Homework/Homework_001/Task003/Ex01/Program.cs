int GetNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void ParCheck(int a)
{
    if(a%2==0)
{
    Console.WriteLine("Данное число четное");
}
else
{
    Console.WriteLine("Данное число не четное");
}
}
int a = GetNumber("Введите число: ");
ParCheck(a);
