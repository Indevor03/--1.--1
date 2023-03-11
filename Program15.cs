// Напишите программу, которая
// 1. Принимает на вход цифру, обозначающую день недели
// 2. Проверяет, является ли этот день выходным.
// 1 -> нет
// 2 -> нет
// 3 -> нет
// 4 -> нет
// 5 -> нет
// 6 -> да
// 7 -> да

Console.WriteLine("Ввод номера дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Понедельник");
    Console.WriteLine("Будни");
}
else if (number == 2)
{
    Console.WriteLine("Вторник");
    Console.WriteLine("Будни");
}
else if (number == 3)
{
    Console.WriteLine("Среда");
    Console.WriteLine("Будни");
}
else if (number == 4)
{
    Console.WriteLine("Четверг");
    Console.WriteLine("Будни");
}
else if (number == 5)
{
    Console.WriteLine("Пятница");
    Console.WriteLine("Будни");
}
else if (number == 6)
{
    Console.WriteLine("Суббота");
    Console.WriteLine("Выходной");
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье");
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("**ALES**");
}
