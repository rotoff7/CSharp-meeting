Console.Write("Введите размер массива: ");
string SizeFromConsole = Console.ReadLine();
int size = int.Parse(SizeFromConsole); // Перевод типа данных "string" в "int"
int[] numbers = new int[size];
int index = 0;
while (index<size)
{
    numbers[index] = new Random().Next(1, 100);
    index = index + 1;
}
int max = 0;
int max_index = 0;
index = 0;
while (index<size)
{
    if (numbers[index] > max)
    {
        max = numbers[index];
        max_index = index;
        index = index + 1;
    }
    else
    {
        index = index + 1;
    }
}
int help = numbers[size - 1];
numbers[size - 1] = max;
numbers[max_index] = help;
var str = string.Join(" ", numbers); //Этот момент не понятен
Console.WriteLine(max);
Console.WriteLine(str);