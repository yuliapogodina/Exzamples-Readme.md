//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();

Console.WriteLine("Введите номер дня недели (российская вариация): ");
int countday = Convert.ToInt32(Console.ReadLine());

if (countday > 7 || countday < 1) Console.WriteLine("Не является днем недели");
else Console.WriteLine(countday == 6 || countday == 7 ? $"Это выходной день" : $"Это будний день");