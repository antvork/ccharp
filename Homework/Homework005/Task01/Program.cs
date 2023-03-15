// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
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

int GetEvenElArr(int[] array)
{
    int result = 0;
    for(int i = 0; i<array.Length; i++ )
    {
        if(array[i]%2 ==0)
        {
            result++;
        }
    }
    return result;
}

int[] myArray = new int[4];
FillArray(myArray);
int x = GetEvenElArr(myArray);
Console.WriteLine($" [{PrintArray(myArray)}]-->{x}");
