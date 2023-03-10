int[] array1 = { 4, 5, 7, 1, 2, 8, 3, 6, 2, -1, -5 };
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = array1[i] * - 1;
}
PrintArray(array1);