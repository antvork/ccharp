// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
double[] GetCordinate(double a1, double a2, double b1, double b2)
{
    double[] array = new double[2];
    array[0] =  (b2-b1)/(a1-a2);
    array[1] = a1*array[0]+b1;
    return array;
}

double k1 =GetNumber("Введите число k1: ");
double k2 =GetNumber("Введите число k2: ");
double b1 =GetNumber("Введите число b1: ");
double b2 =GetNumber("Введите число b2: ");



double[] result = GetCordinate(k1, k2, b1, b2);
Console.WriteLine($"({result[0]} : {result[1]})");
