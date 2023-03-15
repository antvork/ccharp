// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 12);
    }
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
string SearchProductOfNumbers(int[] array)
{
    string result = String.Empty;
    int length = array.Length;
    int product = 0;
    int lengthEnd = array.Length - 1;
    for (int i = 0; i < length / 2; i++)
    {
        product = array[i] * array[lengthEnd];
        result = result + product + " ";
        lengthEnd = lengthEnd-1;
    }
    return result;
}

int[] myArray = new int[11];
FillArray(myArray);
Console.WriteLine(PrintArray(myArray));
Console.WriteLine(SearchProductOfNumbers(myArray));
