// Создание массива, проверка его на сумму всех значений, если сумма больше 100, 
// то сортировка от меньшего к большому, если нет, то выдает максимальное значение.

void MassiveFiller(int[] massive) // Заполнение массива
{
    int index = 0;
    while (index < massive.Length)
    {
        massive[index] = new Random().Next(1, 10);
        index++;
    }
}
int MassiveSum(int[] fullmassive) // Расчет суммы всех чисел массива.
{
int index = 0;
int sum = 0;
while (index<fullmassive.Length)
{
    sum = sum + fullmassive[index];
    index++;
}
return(sum);
}
bool SumChecker(int sumnum)
{
return sumnum > 100;
}
void MassiveSorting(int[] bigmassive)
{
int index = 0;
int maxPos = bigmassive[index];
int max = bigmassive[index];
int size = bigmassive.Length;
int sortsize = bigmassive.Length;
int count = 0;
while (count < sortsize)
{
while (index<sortsize)
{
    if (bigmassive[index] > max)
    {
        max = bigmassive[index];
        maxPos = index;
    }
    index++;
}
int help = bigmassive[sortsize];
bigmassive[sortsize] = max;
bigmassive[maxPos] = help;
sortsize = sortsize - 1;
count++;
}
}