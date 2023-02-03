
int UserInput()
{
    int num;
    if (int.TryParse(Console.ReadLine(), out num)) ;
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        Environment.Exit(0);
    }
    return num;
}

int NumberFactorial(int number)
{
    if (number == 1) return 1;
    else return number * NumberFactorial(number - 1);
}

int num = UserInput();
int result = 1;
for (int i = 1; i <= num; i++)
{
  Console.WriteLine(NumberFactorial(i));
}