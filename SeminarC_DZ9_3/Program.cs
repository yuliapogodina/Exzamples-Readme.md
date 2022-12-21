// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

Console.Clear();
Console.Write("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Наибольший общий делитель чисел M = {m}, N = {n} -> {CalculateDivisorOfDigits(m, n)}");

int CalculateDivisorOfDigits(int a, int b)
{
    if (a == 0) return b;
    else{
    if (a > b) (a, b) = (b, a);
    return CalculateDivisorOfDigits(b - a, a);}
}