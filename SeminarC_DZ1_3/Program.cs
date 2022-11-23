//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет

Console.Clear();

int vvod;

Console.WriteLine("Введите целое число");

vvod = Convert.ToInt32(Console.ReadLine());

if (vvod < 0)
{
    vvod = vvod * (-1);
}

if ((vvod % 2) == 0)
{
    Console.WriteLine("Это четное число");
}

else if ((vvod % 2) > 0)
{
    Console.WriteLine("Это не четное число");
}