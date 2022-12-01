//Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M.
//2,3 -> 8, 27
//1,5 -> 1, 8, 27, 64, 125

double Exponent(int number, int x)
{
    double a = Math.Pow(number, x);
    return a;
}

Console.Write("Введите число 1: ");
int startnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2, больше предыдущего: ");
int finishnumber = Convert.ToInt32(Console.ReadLine());

int exp = 3; // можно запросить ввод этого параметра

for (int i = startnumber; i <= finishnumber; i++)
    Console.WriteLine($"Число {i} в 3 степени = {Exponent(i, exp)}");

