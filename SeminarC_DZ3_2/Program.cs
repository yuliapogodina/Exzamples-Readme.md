//Является ли число полиндромом: 12321 - да,  123421 -  нет

Console.Write("Введите число: ");
string numstring = (Console.ReadLine() ?? " ");
Console.WriteLine(numstring == "" ? "Ничего не было введено!" : "");

// определение разрядности числа
int FindCounNumber(string x)
{
    int input = Convert.ToInt32(x);
    int r = 0;
    while (input > 0)
    {
        r++;  // и есть разрядность
        input /= 10;
    }
    return r;
}
// развернуть число в обратном порядк
int GetTurnNumber(int inputnumber, int count)
{
    int i = count;
    int outputnum = 0;
    for (int j = 0; j < count; j++)
    {
        --i;
        int b = Convert.ToInt32(Math.Pow(10, i));
        int a = inputnumber / b;
        outputnum = outputnum + a * Convert.ToInt32(Math.Pow(10, j));
        inputnumber = inputnumber - a * b;
    }
    return outputnum;
}


// преобразование строки в число
int num = Convert.ToInt32(numstring);

Console.WriteLine(GetTurnNumber(num, FindCounNumber(numstring)) == num ? "Полиндром" : "Не полиндром");