
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
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
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


int[,] myMatrixA = new int[,]
{
{3,5},
{2,1},
};
int[,] myMatrixB = new int[,]
{
{8,2,3},
{1,7,2},
};

int[,] resMatrix = GetProdutMatrix(myMatrixA, myMatrixB);

PrintArray(resMatrix);
