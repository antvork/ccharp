void FillArray(int[] collection) //В аргументы мы должны вставить массив //Данный метод заполняет массив числами от 1 до 9
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //Данный метод распечатывает массив на новой строке пока есть данные  в массиве
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int [] array = new int[10]; // создание массива с 10 элементами заполненый 0


FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = Index0f(array, 9);
Console.WriteLine(pos);
