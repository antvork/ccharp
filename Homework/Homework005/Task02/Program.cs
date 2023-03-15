// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
}


int GetSumPosElArr(int[] array)
{
    int result = 0;
    for(int i = 1; i<array.Length; i=i+2)
    {
        result = result+array[i];
    }
    return result;
}

string PrintArray(int[] array)
{
    string nArray = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
     nArray = nArray + array[i] + " ";
    }
    return nArray;
}

int[] myArray = new int[5];
FillArray(myArray);
int x = GetSumPosElArr(myArray);
Console.WriteLine($" [{PrintArray(myArray)}]-->{x}");