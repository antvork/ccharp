using static Library;
int[] array1 = { 4, 5, -7, -1, 2, 8, 3, 6, 2, -1, -5 };

Console.WriteLine("Сумма отрицательных элементов массива: " + GetNegativeResult(array1));
Console.WriteLine("Сумма положительных элементов массива: " + GetPositiveResult(array1));




//static (int p, int n) GetPosNeg(int[] array1)  // Метод с воззвратом 2 значений
//{
//    int positiv = 0;
//    int negativ = 0;
//    for (int i = 0; i < array1.Length; i++)
//    {
//        if (array1[i] > 0)
//        {
//            positiv = positiv + array1[i];
//        }
//        else
//        {
//            negativ = negativ + array1[i];
//        }
//    }
//    return(positiv, negativ);
//}
//var x = GetPosNeg(array1);

//(int p, int n) x = GetPosNeg(array1);


//Console.WriteLine(x.p);
//Console.WriteLine(x.n);