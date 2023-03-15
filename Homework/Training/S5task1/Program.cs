// Задача 2
// Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
//   Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool TriangleSidesCheck(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a) return true;
    return false;
}
string PrintResult(int a, int b, int c, bool exist)
{
    if (exist) return $"Триугольник со сторонами AB={a} BC={b} CA={c} соответсвует теореме";
    return "Такого триугольника быть не может";
}
Console.WriteLine("Введите длинну стороны AB");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну стороны BC");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну стороны CA");
int c = Convert.ToInt32(Console.ReadLine());

bool result = TriangleSidesCheck(a, b, c);

Console.WriteLine(PrintResult(a, b, c, result));