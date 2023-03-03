int GetNumber(string text) // проверка делимости числа на 23 и 7
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

bool Check(int value)
{
  return value % 7 == 0 && value % 23 == 0;
}

int value = GetNumber("Введите value: ");
bool flag = Check(value);
System.Console.WriteLine(flag);