int[] numbers = { 1, 7, 3, 5, 4};
int index = 0;
int size = numbers.Length;
int max = 0;
int max_index = 0;
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