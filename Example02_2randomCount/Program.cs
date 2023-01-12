Random rnd = new Random();
int number1 = rnd.Next(-10, 101);
int number2 = rnd.Next(-10, 101);
int sum = number1+number2;
Console.Write("number 1 is: ");
Console.WriteLine(number1);
Console.Write("number 2 is: ");
Console.WriteLine(number2);
Console.Write("Сумма двух чисел = ");
Console.WriteLine(sum);
// Random rnd = new Random(); - Создание объекта для генерации чисел, обращаясь к которому через rnd.Next(Диапазон), мы будем помещать рандомное число в переменную.
// Без созданного объекта для генерации рандомных чисел, можно напрямую задать ее через: int numberX = new Random.Next(Диапазон);
