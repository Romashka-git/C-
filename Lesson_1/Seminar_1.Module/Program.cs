// Написать программу вычисления модуля числа


System.Console.WriteLine("Введите число, а я выведу его модуль: ");
int a = int.Parse(Console.ReadLine());
int var = a;

if (a > 0)
{
    Console.WriteLine("Модуль числа " + var + " равен: " + a);
} 
if (a < 0)
{
    a = a * -1;
    Console.WriteLine("Модуль числа " + var + " равен: " + a);
}