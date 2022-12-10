// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Поиск точки пересечения двух уравнений прямой y=kx+b");
Console.WriteLine("Введите параметры уровнения 1: Коэффициент (k1) и добавочное число (b1)");
int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите параметры уровнения 2: Коэффициент (k2) и добавочное число (b2)");
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());

(int, int) FindIntersectionCoodinate(int coefficient1, int coefficient2, int correct1, int correct2)
{
    int x;
    if ((correct1 - correct2) == 0) x = -1 * (coefficient1 - coefficient2);
    else x = -1 * (coefficient1 - coefficient2) / (correct1 - correct2);
    int y = coefficient1 * x + correct1;
    return (x, y);
}

Console.WriteLine($"Координата x: {FindIntersectionCoodinate(k1, k2, b1, b2).Item1}, Координата y: {FindIntersectionCoodinate(k1, k2, b1, b2).Item2}");
