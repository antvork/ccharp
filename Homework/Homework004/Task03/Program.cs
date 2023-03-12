//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
using static Library;

int num = GetNumber("Введите число: ");
int min = GetNumber("Введите минимальное значение: ");
int max = GetNumber("Введите максимальне значение: ");
int[] myArray = GenerateArray(num, min, max);

Console.WriteLine(printArray(myArray));