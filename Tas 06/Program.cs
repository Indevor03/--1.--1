// Напишите программу, которая
// 1. Принимает на вход число
// 2. Выводит, является ли число чётным (делится ли оно на два без остатка)

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Ввести число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1 || number <= 1)
{
    Console.WriteLine("Нечет");
}
else
{
    Console.WriteLine("Чёт");
}
