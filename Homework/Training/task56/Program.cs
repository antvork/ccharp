//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int GetMaxRow(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] = array[i] + matrix[i, j];
        }
    }

    for (int k = 0; k < array.Length; k++)
    {
        int minSum = array[0];
        if (array[k] < minSum)
        {
            minSum = array[k];
            result = k + 1;
        }
    }
    return result;
}
int[,] myMatrix = new int[4, 3];
FillMatrix(myMatrix);
PrintMatrix(myMatrix);
Console.WriteLine(GetMaxRow(myMatrix));
