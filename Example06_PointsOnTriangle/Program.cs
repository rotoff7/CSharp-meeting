﻿Console.Clear();

int xa = 2, ya = 2,
xb = 2, yb = 30,
xc = 100, yc = 30;

int count = 0;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

while (count<20000)
{
    int help = new Random().Next(0,3);
    if (help == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (help == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (help == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}


