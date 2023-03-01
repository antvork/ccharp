Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите позицию");
//int s = Convert.ToInt32(Console.ReadLine());
//int m = 1;
//while (s > 1) {
//     m *= 10;
//     s--;
//}
int m = 100;
int one = (x % m)/10;

Console.WriteLine(one);