public static class Library
{
    public static int GetNumber(string text)  // второй способ
    {
        Console.WriteLine(text);
        string readImput = System.Console.ReadLine();
        return int.Parse(readImput);  //Конвертер для чисел из строк
    }

    public static int[] GenerateArray(int length, int minValue, int maxValue) //Генератор массива (с задаваемыми размерами)
    {
        int[] array = new int[length];
        // Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = new Random().Next(minValue, maxValue + 1);
            // array[i] = random.Next(minValue, maxValue + 1);
        }
        return array;
    }
    public static string printArray(int[] collection)
    {
        string elmassiv = String.Empty;
        for (int i = 0; i < collection.Length; i++)
        {
            elmassiv = elmassiv + collection[i] + " ";
        }
        return elmassiv;
    }

}