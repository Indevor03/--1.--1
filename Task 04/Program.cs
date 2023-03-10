// Напишите программу, которая
// 1. На вход принимает три числа
// 2. Определяет наибольшее из них

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Ввод a");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввод b");
int numberb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввод c");
int numberc = Convert.ToInt32(Console.ReadLine());
if (numbera > numberb && numbera > numberc)
{
    Console.WriteLine("Наибольшее число a");
}
else
if (numberb > numbera && numberb > numberc)
{
    Console.WriteLine("Наибольшее число b");
}
else
if (numberc > numbera && numberc > numberb)
{
    Console.WriteLine("Наибольшее число c");
}
