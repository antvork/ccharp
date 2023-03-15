string PrintArray(int[] array)
{
    string nArray = String.Empty;
    int length = array.Length;
    for (int i = 0; i < length--; i++)
    {
     nArray = nArray + array[i] + " ";
    }
    nArray = nArray + array[length];
    return nArray;
}
int[] nArray = new int[10];
Console.WriteLine(PrintArray(nArray));