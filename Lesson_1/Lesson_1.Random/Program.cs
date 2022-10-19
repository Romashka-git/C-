Console.Write("Сложение двух чисел. Первое случайное от 1 до 10, второе - заданное пользователем. Введите любое целое число: ");
int a = new Random().Next(1, 11); // 1, 2, 3, ... 10
int b = int.Parse(Console.ReadLine());
int c = a + b;
Console.Write("Сумма случайного числа " + a);
Console.Write(" и введенного числа " + b);
Console.Write(" равна: " + c);