
//Напишите метод(-ы), который принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве. 
//A (3,6,8); B (2,1,-7), -> 15.84;  A (7,-5, 0); B (1,-1,9) -> 11.53
int CoordinateABC(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int xa = CoordinateABC("Введите координату А1: ");
int ya = CoordinateABC("Введите координату A2: ");
int za = CoordinateABC("Введите координату A3: ");
int xb = CoordinateABC("Введите координату B1: ");
int yb = CoordinateABC("Введите координату B2: ");
int zb = CoordinateABC("Введите координату B3: ");


double result = Math.Sqrt((Math.Pow((xa-xb), 2)+Math.Pow((ya-yb), 2)+Math.Pow((za-zb), 2))); 

result = Math.Round(result, 2);
Console.WriteLine($" Расстояние между координатами A и B равно: {result}");