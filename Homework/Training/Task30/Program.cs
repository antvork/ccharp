//Задача 30: Напишите программу, которая выводит массив из N элементов, заполненный нулями и единицами 
//в случайном порядке, первый элемент массива не может быть равен нулю
//N=8 -> [1,0,1,1,0,1,0,0]
//N=3 -> [1,1,0]

int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    array[0] = 1;
    for (int index = 1; index < array.Length; index++)
    {
        array[index] = new Random().Next(2); //Заполняет от 0 до 1
    }
}
void PrintArray(int[] array)
{
    for (int position = 0; position < array.Length; position++)
    {
        Console.Write(array[position]);
    }
}
int arrayLength = GetNumber("Введите длинну массива: ");

int[] myArray = new int[arrayLength];
FillArray(myArray);
PrintArray(myArray);


