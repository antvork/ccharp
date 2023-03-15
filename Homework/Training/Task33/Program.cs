// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void SearchAndPrintNumberInArr(int[] array, int n)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] == n)
        {
            result = result + 1;
            break;
        }
    }
    if (result > 0)
    {
        Console.Write("[");
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write($"{array[j]} ");
        }
        Console.Write("]--> Да");
    }
    else
    {
        Console.Write("[");
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write($"{array[j]} ");
        }
        Console.Write("]--> Нет");
    }
}



int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] myArray = new int[10];
FillArray(myArray);
int x = GetNumber("Введите число для поиска в массиве: ");
SearchAndPrintNumberInArr(myArray, x);



