Console.WriteLine("Введите число 1: ");
int x = Convert.ToInt32(Console.ReadLine() ?? "");
Console.WriteLine("Введите число 2 > 1-го: ");
int y = Convert.ToInt32(Console.ReadLine() ?? "");

Console.WriteLine($"Произведение чисел от {x} до {y} = {GetProductNumbers(x, y)}");

int GetProductNumbers(int a, int b)
{
    int result = 1;
    for (int i = a; i <= b; i++)
    {
        result = result * i;
    }
    return result;
}


//Задача 28: Напишите программу, которая принимает на вход число M и N и выдаёт произведение чисел от M до N.
//2,4 -> 24 
//1,5 -> 120
