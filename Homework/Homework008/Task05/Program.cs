// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

void FillMatrixSpiral(int[,] matrix)
{
    int num = 1;
    int col = matrix.GetLength(1) - 1;
    int row = matrix.GetLength(0) - 1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        matrix[0, i] = num;
        num = num + 1;
    }
    for (int j = 1; j < matrix.GetLength(0); j++)
    {
        matrix[j, row] = num;
        num = num + 1;
    }
    for (int k = col - 1; k >= 0; k--)
    {
        matrix[col, k] = num;
        num = num + 1;
    }
    for (int l = row - 1; l >= 1; l--)
    {
        matrix[l, 0] = num;
        num = num + 1;
    }
    for (int q = 1; q < col; q++)
    {
        matrix[1, q] = num;
        num = num + 1;
    }
    for (int e = col - 1; e > 0; e--)
    {
        matrix[2, e] = num;
        num = num + 1;
    }
}




int[,] myMatrix = new int[4, 4];
FillMatrixSpiral(myMatrix);
PrintMatrix(myMatrix);