﻿// Напистаь программу, принимающая на вход число и выдающая квадрат этого числа

Console.Write("Введите чило для возведение его в квадрат: ");
// int a = int.Parse(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());
int b = a * a;
Console.Write("Квадрат числа " + a + " равен " + b);
