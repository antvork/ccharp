int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void CheckPolindrome(int num)
{
    int numA = 0;
    int numB = 0;
    int numC = 0;
    if (num > 9999 && num < 100000)
    {
        numA = num / 1000;
        numB = num % 100;
        numC = numA / 10 + ((numA % 10) * 10);
        if (numB == numC)
        {
            Console.WriteLine("Число полиндром");
        }
        else
        {
            Console.WriteLine("Число не полиндром");
        }
    }
    else
    {
        Console.WriteLine("Число не соответсвует парраметрам");
    }
}

int number = GetNumber("Введите пятизначное число");
CheckPolindrome(number);


