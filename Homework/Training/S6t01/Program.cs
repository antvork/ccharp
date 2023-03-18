

int[,] matrix1 = new int[3, 3];
int[,] matrix2 = new int[3, 3];
int[,] result = new int[3, 3];

int[,] GetSumMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[3, 3];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            result[i, j] = matrix1[i, j] + matrix2[i, j];
        }

    }
    return result;
}