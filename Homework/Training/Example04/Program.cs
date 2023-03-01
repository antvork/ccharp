Console.WriteLine("Введите число");  // программа прсит число и после удаляет ту позицию что вы запросили
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию");
int s = Convert.ToInt32(Console.ReadLine());
int m = 1;
while (s > 1) {
     m *= 10;
     s--;
}
int t = (x % m) + (x / (m * 10)) * m;
Console.WriteLine(t);