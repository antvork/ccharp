//Задача* На вход подаётся массив 0 и 1 представляющий двоичное число
//* Написать программу, получающую из этого представления десятичное число

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
double GetDecimalNum(int[] arr)
{
    double number = 0;
    int a = arr.Length - 1;
    for (int i = 0; i < arr.Length; i++)
    {
        number = number + arr[i] * Math.Pow(2, a);
        a = a - 1;
    }

    return number;
}
//Клиентский код
int arrayLength = GetNumber("Введите длинну массива: ");
int[] myArray = new int[arrayLength];
FillArray(myArray);
Console.Write("Массив: ");
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine("Массив преобразованный в десятичное число виде: " + GetDecimalNum(myArray));
