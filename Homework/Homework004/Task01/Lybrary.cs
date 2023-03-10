public static class Library
{
    public static int GetNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int GetDegree(int num, int st)
    {
        int result = 1;
        for (int i = 0; i < st; i++)
        {
            result = result * num;
        }
        return result;
    }
}