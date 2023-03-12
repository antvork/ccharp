// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
//  сумма отрицательных равна -20.

void FillArray(int[] myArray)
{
    for (int index = 0; index < myArray.Length; index++)
    {
        myArray[index] = new Random().Next(-9, 10);
    }
}
void PrintArray(int[] myArray)
{
    for (int position = 0; position < myArray.Length; position++)
    {
        Console.Write($"{myArray[position]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();



int GetNegativeSumArr(int[] myArray)
{
    int negative = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] < 0)
        {
            negative = negative + myArray[i];
        }
    }
    return negative;
}

int GetPosSumArr(int[] myArray)
{
    int positive = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0)
        {
            positive = positive + myArray[i];
        }
    }
    return positive;
}

int[] myNewArray = new int[12];
FillArray(myNewArray);
PrintArray(myNewArray);
int negative = GetNegativeSumArr(myNewArray);
int positive = GetPosSumArr(myNewArray);

Console.WriteLine("Сумма положительных элементов равна: " + positive);
Console.WriteLine("Сумма отрицательных элементов равна: " + negative);