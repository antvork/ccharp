int GetNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int N = GetNumber("Введите число: ");
int number = 1;

string output = String.Empty;

while (number <= N)
{
    if (number%2==0)
    {
        if(number >= N-1)
        {
            output = output + number + ".";
        }
        else
        {
            output = output + number + ", ";
        }
    }
    number++;
}
System.Console.WriteLine(output);