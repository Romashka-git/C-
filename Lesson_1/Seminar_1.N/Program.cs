// написать программу, которая на вход принимает одно число,
// а на выходе показывает все целые числа от -N до N


System.Console.Write("Введите целое положительное число: ");
int n = int.Parse(Console.ReadLine());

int count = -n;

while (count < n)
{
    Console.Write(count + ", ");
    count++;
}
System.Console.WriteLine(count);