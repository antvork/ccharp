int GetNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int MaxValArray(int a, int b, int c)
{
    int[] numbers = { a, b, c };
    int index = 0;
    int max = numbers[0];
    int n = numbers.Length;
    while (index < n)
    {
        if (max < numbers[index])
        {
            max = numbers[index];
        }
        index++;
    }

    return max;
}

void PrintResult(int max)
{
    Console.Write("max = ");
    Console.WriteLine(max);
}


int valueA = GetNumber("Введите число 1: ");
int valueB = GetNumber("Введите число 2: ");
int valueC = GetNumber("Введите число 3: ");

int max = MaxValArray(valueA, valueB, valueC);

PrintResult(max);



