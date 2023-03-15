// Задача 33: Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

bool Check(int[] array, int n)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        if (array[i] == n) return true; // После return метод заканчивает работу
    return false;
}

string PrintResult(int[] array, int el, bool exist)
{
    if (exist) return $"В массиве {String.Join(" ", array)} элемент {el} присутсвует";
    return "В массиве элемента нет";
}
int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
int find = 99;
bool c = Check(myArray, find);
Console.WriteLine(PrintResult(myArray, find, c));