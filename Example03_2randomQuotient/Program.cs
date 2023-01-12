double number1 = new Random().Next(-10, 101);
double number2 = new Random().Next(-10, 101);
// Данная команда генерирует рандомные числа в следующем диапазоне [-10; 101)
// Включая в диапазон -10 и не включая 101, то  есть мы можем получить любое число от -10 до 100!
double result = (number1 / number2);
Console.Write("Первое рандомное число: ");
Console.WriteLine(number1);
Console.Write("Второе рандомное число: ");
Console.WriteLine(number2);
Console.Write("Результат от деления первого числа на второе = ");
Console.WriteLine(result);
// Или же можно не создавать переменную result а в выводе сделать вместо Console.WriteLine(result):
//Console.WriteLine(number1 / number2);

