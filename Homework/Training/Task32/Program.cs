//Задача 32:  Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 



void FillArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
     array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
void GetNegativeElArr(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = array[i]*-1;
    }
}
int[] myArray = new int[10];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
GetNegativeElArr(myArray);
PrintArray(myArray);