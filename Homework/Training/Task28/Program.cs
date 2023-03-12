//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36
int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int GetSumNum(int nummber)
{
    int res = 0;
    for (int i = 0; i <= nummber; i++)
    {
        res = res + i;
    }
    return res;
}

int num = GetNumber("Введите число: ");
int res = GetSumNum(num);

Console.WriteLine(res);