int GetNumber (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}



int valueA = GetNumber("Введите число a: ");
int valueB = GetNumber("Введите число b: ");

int max;
if(valueA>valueB)
{
    max=valueA;
}
else
{
    max=valueB;
}
Console.Write("max=");
Console.WriteLine(max);

