// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

string PrintArray(int[] array)
{
    string nArray = String.Empty;
    int length = array.Length;
    for (int i = 0; i < length - 1; i++)
    {
        nArray = nArray + array[i] + " ";
    }
    nArray = nArray + array[length - 1];
    return nArray;
}
void EnterUserNum(int[] array, int quant)
{
    for (int i = 0; i < quant; i++)
    {
        array[i] = GetNumber($"Введите {i + 1} число массива: ");
    }
}
int GetPositiveNum(int[] array)
{
    int positive = 0;
    for(int i = 0; i< array.Length; i++)
    {
        if(array[i]>0) positive++;
    }
    return positive;
}
int quantUser = GetNumber("Введите размер массива: ");
int[] arrayUser = new int[quantUser];
EnterUserNum(arrayUser ,quantUser);
Console.WriteLine(PrintArray(arrayUser));
int result = GetPositiveNum(arrayUser);
Console.WriteLine($"Количество положительных чисел: {result}");