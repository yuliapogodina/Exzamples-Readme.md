//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
string str = (Console.ReadLine() ?? "1");

char[] ch = str.ToCharArray();

int length = ch.Length;
Console.WriteLine("Length is " + length);

if (length > 2)

    Console.WriteLine(ch[2]);

else
    Console.WriteLine("третьей цифры нет");