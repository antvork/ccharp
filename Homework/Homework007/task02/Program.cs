// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillMatrix(int[,] matrix)
{
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        for (var j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] array)
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

bool CheckPositinMatrix(int[,] matrix, int horizontal, int vertical)
{

    if (horizontal<matrix.GetLength(0)&& vertical<matrix.GetLength(1)) return true;
    else return false;
    
}

string PrintResult(int[,] matrix, int horizontal, int vertical, bool exist)
{
    if (exist) return $"Элемент в матрице [{horizontal}, {vertical}] присутсвует, его значение {matrix[horizontal, vertical]}";
    return $"В матрице элемента {horizontal}, {vertical} нет";
}


int[,] myMatrix = new int[5, 6];
FillMatrix(myMatrix);
PrintMatrix(myMatrix);
int hor = GetNumber("Введите позицию по горизонтали: ");
int vert = GetNumber("Введите позицию по вертикали: ");
bool c = CheckPositinMatrix(myMatrix, hor, vert);
Console.WriteLine(PrintResult(myMatrix, hor, vert, c));