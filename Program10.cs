// Напишите программу, которая
// 1. Принимает на вход трёхзначное число
// 2. На выходе показывает вторую цифру этого числа

// 735 -> 3
// 243 -> 4
// 573 -> 7

int Prompt(string msg)
{
    Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}
int Number = Prompt("Введите трехзначное число");
if (Number >= 100 && Number < 1000)
{
    int mid = (Number % 100 - Number % 10) / 10;
    Console.WriteLine($"Вторая цифра {mid}");
}
else
{
    Console.WriteLine("Это число не трехзначное");
}
