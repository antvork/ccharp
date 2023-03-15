// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
}
double GetDiffArrEll(double[] array)
{
    double maxEl = array[0];
    double minEl = array[0];
    for(int i = 0; i<array.Length; i++)
    {
        if(maxEl<array[i])
        {
            maxEl=array[i];
        }
        if(minEl>array[i])
        {
            minEl = array[i];
        }
    }
     return maxEl - minEl;
}

string PrintArray(double[] array)
{
    string nArray = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
     nArray = nArray + array[i] + " ";
    }
    return nArray;
}

double[] myArray = new double[5];
FillArray(myArray);
double x = GetDiffArrEll(myArray);
Console.WriteLine($" [{PrintArray(myArray)}]-->{x}");