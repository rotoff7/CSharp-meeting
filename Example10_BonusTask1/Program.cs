// Создание массива, проверка его на сумму всех значений, если сумма больше 100, 
// то сортировка от меньшего к большому, если нет, то выдает максимальное значение.

void MassiveFiller(int[] massive) // Заполнение массива
{
    int index = 0;
    while (index < massive.Length)
    {
        massive[index] = new Random().Next(1, 100);
        index++;
    }
}
int MassiveSum(int[] fullmassive) // Расчет суммы всех чисел массива.
{
    int index = 0;
    int sum = 0;
    while (index < fullmassive.Length)
    {
        sum = sum + fullmassive[index];
        index++;
    }
    return (sum);
}
bool SumChecker(int sumnum)
{
    return sumnum > 1000;
}
int[] MassiveSorting(int[] bigmassive)
{
    int count = 0;
    int size = bigmassive.Length;
    int sortsize = size;
    while (count < size)
    {
        int index = 0;
        int max = 0;
        int maxPos = 0;
        while (index < sortsize)
        {
            if (bigmassive[index] > max)
            {
                max = bigmassive[index];
                maxPos = index;
            }
            index++;
        }
        int help = bigmassive[sortsize - 1];
        bigmassive[sortsize - 1] = max;
        bigmassive[maxPos] = help;
        sortsize = sortsize - 1;
        count++;
    }
    return (bigmassive);
}
int MaxFromMassive(int[] unsortmassive)
{
    int index = 0;
    int localmax = 0;
    while (index < unsortmassive.Length)
    {
        if (unsortmassive[index] > localmax)
            localmax = unsortmassive[index];
        index++;
    }
    return (localmax);
}


int defaultvalue = 20;
int[] resultmassive = new int[defaultvalue];
MassiveFiller(resultmassive);
var filledmassive = string.Join(" ", resultmassive);
Console.WriteLine($"Исходный сгенерированный массив: {filledmassive}");
bool res = SumChecker(MassiveSum(resultmassive));
int[] sortedmassive = MassiveSorting(resultmassive);
var varsortedmassive = string.Join(" ", sortedmassive);
int massivemax = MaxFromMassive(resultmassive);
if (res == true)
    Console.WriteLine($"Сумма чисел в массиве больше 1000. \r\nОтсортированный массив будет иметь вид {varsortedmassive}");
else
    Console.WriteLine($"Сумма чисел массива меньше 1000. Максимальное значение числа в массиве -> {massivemax}");

Console.WriteLine("Some other code");

int[] newmassive = new int[defaultvalue];
MassiveFiller(newmassive);
var filledmassive2 = string.Join(" ", newmassive);
Console.WriteLine($"Исходный сгенерированный массив: {filledmassive2}");
res = SumChecker(MassiveSum(newmassive));
int[] sortedmassive2 = MassiveSorting(newmassive);
var varsortedmassive2 = string.Join(" ", sortedmassive2);
massivemax = MaxFromMassive(sortedmassive2);
if (res == true)
    Console.WriteLine($"Сумма чисел в массиве больше 1000. \r\nОтсортированный массив будет иметь вид {varsortedmassive2}");
else
    Console.WriteLine($"Сумма чисел массива меньше 1000. Максимальное значение числа в массиве -> {massivemax}");

// Еще надо попробовать внести повторяющиеся куски кода, связанные с созданием массива и подготовкой его к выводу в методы.