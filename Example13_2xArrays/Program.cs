// Создать двумерный массив. Сделать контур "картинки", закрасить внутреннее поле.

int[,] Array2xCreate(int lines, int columns, int min, int max)
{
    int[,] array = new int[lines, columns];
    Random rnd = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void Print2xArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1) - 1)
                Console.Write($"{arr[i, j]}, ");
            else Console.Write(arr[i, j]);
        }
        Console.WriteLine("]");
    }
}

Console.WriteLine("Введите размеры массива и границы диапазона чисел.");
Console.Write("Введите кол-во строк: ");
int lines;
if (int.TryParse(Console.ReadLine(), out lines) && lines > 0)
{
    Console.Write("Введите кол-во столбцов: ");
    int columns;
    if (int.TryParse(Console.ReadLine(), out columns) && columns > 0)
    {
        Console.Write("Введите левую границу диапазона чисел: ");
        int min;
        if (int.TryParse(Console.ReadLine(), out min))
        {
            Console.Write("Введите правую границу диапазона чисел: ");
            int max;
            if (int.TryParse(Console.ReadLine(), out max) && max >= min)
            {
                int[,] array = Array2xCreate(lines, columns, min, max);
                Console.WriteLine();
                Print2xArray(array);
            }
            else Console.WriteLine("Введено некорректное значение.");
        }
        else Console.WriteLine("Введено некорректное значение.");
    }
    else Console.WriteLine("Введено некорректное значение.");
}
else Console.WriteLine("Введено некорректное значение.");

