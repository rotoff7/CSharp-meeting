// сравнение введенного числа с имеющейся через функцию
// 3 массива (5 ячеек, 7 ячеек, 9 ячеек) и максимальное


int size=0;
int MagicTrick(int arg)
{
    if (arg == 1) size = 5;
    if (arg == 2) size = 7;
    if (arg == 3) size = 9;
    return (size);
}

void MassiveFiller(int[] col)
{
    int size = col.Length;
    int index = 0;
    while (index < size)
    {
        col[index] = new Random().Next(1, 100);
        index++;
    }
}

void MassiveRighter(int[] Fcol)
{
    var Fcole = string.Join(" ", Fcol);
    Console.WriteLine("Получившийся исходный массив: ");
    Console.WriteLine(Fcole);
}

Console.WriteLine("Введите чудо-число");
int MagicNumber = Convert.ToInt32(Console.ReadLine());

MagicTrick(MagicNumber);

int[] massive = new int[size];

MassiveFiller(massive);

MassiveRighter(massive);

Console.WriteLine("SomeCode");

Console.WriteLine("Введите чудо-число");
MagicNumber = Convert.ToInt32(Console.ReadLine());

MagicTrick(MagicNumber);

int[] massive2 = new int[size];

MassiveFiller(massive2);

MassiveRighter(massive2);
