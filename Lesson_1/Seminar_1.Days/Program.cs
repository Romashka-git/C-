// Написать программу, которая будет выдавать название
// дня недели по заданному номеру.


string monday =  "Понедельник";
string tuesday =  "Вторник";
string wednesday =  "Среда";
string thursday =  "Четверг";
string friday =  "Пятница";
string saturday =  "Суббота";
string sunday =  "Воскресенье";

Console.Write("Введите номер дня, а я напишу, какой это день недели. ");
int answer = int.Parse(Console.ReadLine());
if (answer == 1)
{
    Console.WriteLine(monday);
}
if (answer == 2)
{
    Console.WriteLine(tuesday);
}
if (answer == 3)
{
    Console.WriteLine(wednesday);
}
if (answer == 4)
{
    Console.WriteLine(thursday);
}
if (answer == 5)
{
    Console.WriteLine(friday);
}
if (answer == 6)
{
    Console.WriteLine(saturday);
}
if (answer == 7)
{
    Console.WriteLine(sunday);
}
