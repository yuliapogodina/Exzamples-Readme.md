//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();

Console.Write("Введите число отличное от нуля: ");
string numstring = (Console.ReadLine() ?? " ");
int i = 0;
Console.WriteLine(numstring == "" ? "Ничего не было введено!" : " ");//i = FindCounNumber(numstring));

int FindCounNumber(string x)
{

    int num = Convert.ToInt32(x);
    while (num > 0)
    {
        i++;  // и есть разрядность
        num /= 10;
    }

    return i;
}

int SumOfDigit(int n, string a)
{
    int num = Convert.ToInt32(a);
    int sumdigit = 0;
    for(int i = n-1; i < 0; --i)
    {        
        int digit = num / Convert.ToInt32(Math.Pow(10, i));
        num = num - digit * Convert.ToInt32(Math.Pow(10, i));
        sumdigit = sumdigit + digit;
        Console.WriteLine(num);
    }
    return sumdigit;
}

int result = SumOfDigit(i, numstring);
//Console.WriteLine(String.Join(",", arr));
Console.WriteLine(result);
