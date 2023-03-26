//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetProdutMatrix(int[,] array1, int[,] array2)
{

    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    result[0, 0] = 0;
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

int[,] matrix1 = new int[3, 2];
int[,] matrix2 = new int[2, 3];
FillMatrix(matrix1);
FillMatrix(matrix2);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
int[,] resultMatrix = GetProdutMatrix(matrix1, matrix2);
PrintMatrix(resultMatrix);


