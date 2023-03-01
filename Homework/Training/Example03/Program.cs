Console.Write("Введите число: "); // Удаление второго числа

int N = Convert.ToInt32(Console.ReadLine());

int i = N % 10;

N = N / 100;

N = N * 10 + i;

Console.WriteLine(N);