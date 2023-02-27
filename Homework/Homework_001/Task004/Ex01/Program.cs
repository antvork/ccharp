int GetNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int N = GetNumber("Введите число: ");
int number = 1;
while (number <= N)
{
    if (number%2==0)
    {
        if(number >= N-1)
        {
            Console.Write(number+".");
        }
        else
        {
            Console.Write(number+", ");
        }
    }
    number++;
}
