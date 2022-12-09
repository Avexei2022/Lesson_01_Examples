// Personal greeting code
Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Я ждал тебя, Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.WriteLine("!");
}
