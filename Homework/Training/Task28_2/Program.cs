//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int GetзProductNum(int nummber)
{
    int res = 1;
    for (int i = 1; i <= nummber; i++)
    {
        res = res * i;
    }
    return res;
}

int num = GetNumber("Введите число: ");
int res = GetзProductNum(num);

Console.WriteLine(res);