//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.Write("Ведите число: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите степень числа: ");
int exp = Convert.ToInt32(Console.ReadLine());

double Exponent(double x, int y)
{
    double expofx = 1;
    for (int i = 1; i <= y; i++) expofx = expofx * x;
    return expofx;
}

Console.WriteLine($"Число {number} в степени {exp} = {Exponent(number, exp)}");
