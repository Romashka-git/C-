// Написать программу, которая будет выдавать название
// дня недели по заданному номеру.

System.Console.WriteLine("Введите числоЮ соответствующее дню недели: ");
int answer = int.Parse(Console.ReadLine());

string[] days = new string[7] { "пн", "вт", "ср", "чт", "пт", "сб", "вс", };

if (answer > 0 && answer < 8)
{
    Console.WriteLine(days[answer - 1]);
}
else
{
    Console.WriteLine("Необходимо ввести число от 1 до 7");
}
