// Напишите программу, которая на вход принимает 2 числа
// и проверяет, является ли первое число квадратом второго

Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a * a == b)
{
    System.Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("NO!");
}
