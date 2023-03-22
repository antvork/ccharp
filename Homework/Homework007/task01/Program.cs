// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}



void FillMatrix(double[,] matrix)
{
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        for (var j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10) + new Random().NextDouble();
            matrix[i, j] = Math.Round(matrix[i, j], 2);
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

int m = GetNumber("Введите число m ");
int n = GetNumber("Введите число n ");

double[,] myMatrix = new double[m, n];
FillMatrix(myMatrix);
PrintMatrix(myMatrix);