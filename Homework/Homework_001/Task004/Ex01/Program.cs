int GetNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string GetNumberTwo(int count)
{

    string output = String.Empty;
    int number = 1;
    while (number <= count)
    {
        if (number%2==0)
        {
            if(number >= count-1)
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
    return output;
}
int N = GetNumber("Введите число: ");
string res = GetNumberTwo(N);
System.Console.WriteLine(res);