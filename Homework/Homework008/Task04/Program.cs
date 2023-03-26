// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillMatrixCube(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 40);
            }
        }
    }


}
void GetUniqEl(int[,,] matrix)
{
    int numUn = matrix[0, 0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 1; k < matrix.GetLength(2); k++)
            {
                for (int ix = 0; ix < matrix.GetLength(0); ix++)
                {
                    for (int jx = 0; jx < matrix.GetLength(1); jx++)
                    {
                        for (int kx = 0; kx < matrix.GetLength(2); kx++)
                        {
                            if (matrix[i, j, k] == matrix[ix, jx, kx] && ($"{ix}+{jx}+{kx}") != ($"{i}+{j}+{k}"))
                            {
                                matrix[i, j, k] = new Random().Next(40, 70);
                            }
                        }
                    }
                }
            }
        }
    }
}

void PrintMatrixCube(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[j, k, i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] myMatrix = new int[2, 2, 2];
FillMatrixCube(myMatrix);
PrintMatrixCube(myMatrix);
Console.WriteLine();
GetUniqEl(myMatrix);
PrintMatrixCube(myMatrix);