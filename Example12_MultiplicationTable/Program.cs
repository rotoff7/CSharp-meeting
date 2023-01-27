// Вывод таблицы умножения от двойки до введенного значения.

void MultiplicationGeneration(int num)
{
    for (int i = 2; i <= num; i++)
    {
        for (int j = 2; j <= 10; j++)
        {
            int multi = i * j;
            Console.WriteLine($"{i} x {j} = {multi}");
        }
        Console.WriteLine("");
    }
}

Console.Write("Введите верхнюю границу таблицы умножения: ");
int number;
if (int.TryParse(Console.ReadLine(), out number))
    MultiplicationGeneration(number);
else Console.WriteLine("Введено некорректное значение. Введите натуральное число.");
