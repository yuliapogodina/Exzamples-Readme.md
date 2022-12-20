// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в диапазоне, M = {m}, N = {n} -> {CalculateSummOfDigits(m, n)}");

int CalculateSummOfDigits(int valmin, int valmax)
{
    if (valmin >= valmax) return valmin;
    return valmin + CalculateSummOfDigits(valmin+1, valmax);
}