Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же " + username);
}
else
{
    Console.WriteLine("Привет, " + username);
}