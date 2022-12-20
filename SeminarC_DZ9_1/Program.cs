// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

Console.Clear();
Console.Write("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Четные натуральные числа, M = {m}, N = {n} -> ");
PrintValue(m, n);

void PrintValue(int m, int max)
{
    if (m % 2 != 0) m += 1;
    if (m > max) return;
    Console.Write($" {m}");
    PrintValue(m + 2, max);
}
