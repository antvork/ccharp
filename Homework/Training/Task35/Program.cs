// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 123);
    }
}

string PrintArray(int[] array)
{
    string nArray = String.Empty;
    int length = array.Length;
    for (int i = 0; i < length-1; i++)
    {
        nArray = nArray + array[i] + " ";
    }
    nArray = nArray + array[length-1];
    return nArray;
}

int SearchQuant(int[] array)
{
    int sQan = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) sQan++;
    }
    return sQan;
}
int[] myArray = new int[12];

FillArray(myArray);
Console.WriteLine(PrintArray(myArray));
int x = SearchQuant(myArray);
Console.WriteLine(x);


