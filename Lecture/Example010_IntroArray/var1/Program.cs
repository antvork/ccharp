//Найти максимальное из 9 чисел
//Решение через функцию  и через массив

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2> result) result =arg2;
    if (arg3> result) result =arg3;
    return result;
    
}

int [] array = {21,32,34,45,56,67,87,89,59}; //Создаем массив
array[0] = 12; //Присвоение значения массиву

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(result);