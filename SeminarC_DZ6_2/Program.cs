// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Поиск точки пересечения двух уравнений прямой y=kx+b");
Console.WriteLine("Введите параметры уровнения 1: Коэффициент (k1) и добавочное число (b1)");
double k1 = Convert.ToDouble(Console.ReadLine());
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите параметры уровнения 2: Коэффициент (k2) и добавочное число (b2)");
double k2 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());

(double, double) FindIntersectionCoodinate(double coefficient1, double coefficient2, double correct1, double correct2)
{
    double x;
    x = (correct2 - correct1)/(coefficient1 - coefficient2);
    double y = coefficient1 * x + correct1;
    return (x, y);
}

Console.WriteLine($"Координата ({FindIntersectionCoodinate(k1, k2, b1, b2).Item1}; {FindIntersectionCoodinate(k1, k2, b1, b2).Item2})");
