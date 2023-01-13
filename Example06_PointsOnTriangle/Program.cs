Console.Clear();

int xa = 2, ya = 1,
xb = 2, yb = 30,
xc = 100, yc = 30;

Console.Write("Введите кол-во точек: ");
int count = Console.Read();

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;

int index = 0;
while (index < count)
{
    int help = new Random().Next(0, 3);
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
    y = (x + yc) / 2;
    }
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
index = index + 1;
}


