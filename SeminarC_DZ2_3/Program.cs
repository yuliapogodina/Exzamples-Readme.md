//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();

Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

decimal ost = num1 / 1000;

if (ost < 1)
    Console.WriteLine("третьей цифры нет");
else
{
    int result = (num1 % 1000 - num1 % 100) / 100;
    Console.WriteLine($"Третья цифра: {result}");
}