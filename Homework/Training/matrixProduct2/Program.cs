
void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetProdutMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0),array2.GetLength(1)];
    int sum = 0;

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum = sum + array1[i, k] * array2[k, j];
            }
            result[i, j] = sum;
            sum = 0;
        }
    }
    return result;
}

int[,] FillMatrix(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 20);
        }
    }
    return array;
}

int[,] naborArr = new int[7, 3];
int[,] naborArr2 = new int[3, 7];
int[,] productArr = new int[0, 0];
naborArr = FillMatrix(naborArr);
naborArr2 = FillMatrix(naborArr2);
PrintArray(naborArr);
Console.WriteLine();
PrintArray(naborArr2);

productArr = GetProdutMatrix(naborArr, naborArr2);
Console.WriteLine();
PrintArray(productArr);


