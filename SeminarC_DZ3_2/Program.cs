//int num = 123421;
//int i = 6;

Console.Write("Введите число: ");
string numstring = (Console.ReadLine());
int i = 0;
int num;
int num1=0;
int j;

if (numstring == "")
{
    Console.Write("Ничего не было введено!");
}
else
{
    num = Convert.ToInt32(numstring);
    while (num > 0)
    {
        i++;  // и есть разрядность
        num /= 10;
    }
}

num = Convert.ToInt32(numstring);
int count = i;
// пересобрать число в обратном порядке
for (j=0; j<count; j++)
{
--i;
int b = Convert.ToInt32(Math.Pow(10, i));
int a = num / b;
num1 = num1 + a*Convert.ToInt32(Math.Pow(10, j));
num = num - a*b;
}
num = Convert.ToInt32(numstring);
Console.WriteLine(num1==num ? "Полиндром": "Не полиндром");