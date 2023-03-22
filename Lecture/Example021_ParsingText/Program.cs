using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "") //Заменяет ( на пустое значение
                .Replace(")", "") //Заменяет ) на пустое значение
                ;
Console.WriteLine(text);

var data = text.Split(" ") //Разбивает строку по " "
                .Select(item => item.Split(',')) //Select - выборка  spit  - признак разделения
                .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1]))) //Создает массив кортежей и присвоение первому элементу .Item x ворому .y
                .Where(e =>e.x%2 ==0) //Where - где (условие)
                .Select(point => (point.x*10, point.y)) // обработка  данных масива
                .ToArray(); // преобразует в массив

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    Console.WriteLine();
}