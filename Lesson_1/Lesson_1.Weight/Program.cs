// Задача найти максимально тяжелую гирю.


int a = 6;
int b = 5;
int c = 8;
int d = 1;
int e = 9;
int max = a; 

if (b > max) max = b;
if (a > max) max = a;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Max = ");
Console.WriteLine(max);