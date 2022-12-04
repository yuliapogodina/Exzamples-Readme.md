//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();

Console.Write("Введите число отличное от нуля: ");
string numstring = (Console.ReadLine() ?? " ");
Console.WriteLine(numstring == "" ? "Ничего не было введено!" : " ");

int GetSumOfDigit(string a)
{
    int num = Convert.ToInt32(a);
    int sumdigit = 0;
    while (num > 0)
    {
        sumdigit = sumdigit + num % 10;
        num = num / 10;
    }
    return sumdigit;
}

Console.WriteLine($"Сумма цифр в числе {numstring} = {GetSumOfDigit(numstring)}");
