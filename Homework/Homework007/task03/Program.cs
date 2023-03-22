// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}

double[] GetArithmeticMean(double[,] matrix)
{
    double result =0;
    double[]output = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result = result + matrix[j,i];
        }
        output[i] = result / matrix.GetLength(0);
        result =0;
    }
    return output;
}

void PrintResult(double[] array)
{
    int length = array.Length;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[length-1]}.");
}

double[,] newMatrix = new double[5,6];
FillMatrix(newMatrix);
PrintMatrix(newMatrix);
double[]arithResult = GetArithmeticMean(newMatrix);
PrintResult(arithResult);

