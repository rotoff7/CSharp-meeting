Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "максим")
{
 Console.Write("Ура! Вновь приветствую тебя ");
 Console.WriteLine(username);
 Console.Write("Твое счастливое число сегодня: ");
 int HappyNumber = new Random().Next(1, 101);
 Console.WriteLine(HappyNumber);
}
else
{
    if(username.ToLower() == "петя") // Параметр .ToLower() приводит имя пользователя при проверки условия к нижнему регистру (как бы пользователь его не написал)
    {
     Console.Write("Ой нет, опять ты...");
    }
    else
    {
     Console.Write("Привет ");
     Console.WriteLine(username);
    }
}