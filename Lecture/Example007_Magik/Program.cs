﻿Console.Clear(); // Отчищает экран кнсоли
//Console.SetCursorPosition(10, 4); // Определяет область экрана в символах
//Console.WriteLine("+"); // Ставит +

int xa = 40, ya = 1,
    xb = 1, yb = 40,
    xc = 80, yc = 40;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x=xa, y=xb;
int count = 0;

while(count<10000)
{
    
    int what = new Random().Next(0, 3); // Генератор сл чисел выдающий [0; 3) 0 1 2
    if(what == 0)
    {
        x = (x+xa) / 2;
        y = (y+ya) / 2;
    }

    if(what == 1)
    {
        x = (x+xb) / 2;
        y = (y+yb) / 2;
    }
    if(what == 2)
    {
        x = (x+xc) / 2;
        y = (y+yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");  
    count++; // count = count + 1 // count +=1
    Console.SetCursorPosition(1, 41);
    Console.WriteLine(count);
}
