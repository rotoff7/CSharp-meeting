Console.Write("Введите размер массива: ");
string SizeFromConsole = Console.ReadLine();
int size = int.Parse(SizeFromConsole); // Перевод типа данных из "string" в "int"
int[] numbers = new int[size];
int index = 0;
while (index<size)
{
    numbers[index] = new Random().Next(1, 100);
    index = index + 1;
}
var massive = string.Join(" ", numbers); //Этот момент не понятен
Console.WriteLine("Получившийся исходный массив: ");
Console.WriteLine(massive);

int max = 0;
int max_index = 0;
index = 0;
while (index<size)
{
    if (numbers[index] > max)
    {
        max = numbers[index];
        max_index = index;
    }
        index = index + 1;
}
index = max_index;
int help = numbers[max_index];
while (index<size - 1) // Цикл для смещения чисел
{
    numbers[index]=numbers[index+1];
    index=index+1;
}
numbers[size-1] = help;

var massive2_0 = string.Join(" ", numbers); // Еще раз, иначе выведет старый массив

Console.Write("Максимальное число в массиве: ");
Console.WriteLine(max);
Console.WriteLine("Результативный массив: ");
Console.WriteLine(massive2_0);

// int help = numbers[size - 1];
// numbers[size - 1] = max;
// numbers[max_index] = help;
// Console.WriteLine("Помощь: ");
// Console.WriteLine(numbers[6]);
// Console.WriteLine(help);
// Console.WriteLine(max_index);