// Найти кубы чисел от 1 до N (24)

int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
string GetResult(int n)
{
    int index = 1;
    string result = String.Empty; //Присвоение пустой строки (также как для числа)
    while (index <= n)
    {
        int sqr = index * index * index;
        result = result + "[" + index + "==>" + sqr + "] "; //Контатинация строк( тут в результат добавляется еще строки)
        index++;
    }
    return result;
}
int x = GetNumber("Введите число: ");
Console.WriteLine(GetResult(x));