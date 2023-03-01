Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int hundred = 100;
int ten = 10;
int result;
if (number > 99 && number < 1000)
{
    result = (number % hundred) / ten;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
