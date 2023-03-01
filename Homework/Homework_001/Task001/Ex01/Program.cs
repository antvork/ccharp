int GetNumber (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}



int valueA = GetNumber("Введите число a: ");
int valueB = GetNumber("Введите число b: ");

int max = valueB;
if(valueA>valueB)
{
    max=valueA;
}
//else
//{
//    max=valueB;  // Если мы задали max сразу то можно не проверять второе
//}
Console.Write("max=");
Console.WriteLine(max);

