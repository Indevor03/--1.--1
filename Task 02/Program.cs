// Напишите программу, которая
// 1. На вход принимает два числа
// 2. Определяет наибольшее из них

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Ввод a");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввод b");
int numberb = Convert.ToInt32(Console.ReadLine());
if (numbera < numberb)
{
    Console.WriteLine("Наибольшее число b, наименьшее число a");
}
else
{
    Console.WriteLine("Наибольшее число а, нименьшее число b");
}