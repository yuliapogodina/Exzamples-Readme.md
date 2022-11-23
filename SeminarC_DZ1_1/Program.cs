//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine("Введите число 1:");

int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");

int numB = Convert.ToInt32(Console.ReadLine());

if (numA < numB)
{
    Console.WriteLine($"max = {numB} min = {numA}");
}
else if (numA > numB)
{
    Console.WriteLine($"max = {numA} min = {numB}");
}
else if (numA == numB)
{
    Console.WriteLine("Значения равны");
}