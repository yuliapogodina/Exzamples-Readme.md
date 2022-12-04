//Дополнительная задача (задача со звёздочкой): Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
//10 -> 4
//20 -> 7
//30 -> 8

Console.Clear();
Console.Write("Введите радиус окружности:");
int radius = Convert.ToInt32(Console.ReadLine());
double sofcircle = Math.PI * Math.Pow(radius, 2);

int GetMaxDigit(double s)
{
int maxdigit = 0;
s = Convert.ToUInt32(s);
while (s > 0)
{
    int digit = Convert.ToInt32(s % 10);
    if (digit > maxdigit) maxdigit = digit;
    s = s/10;
}
return maxdigit;
}

Console.WriteLine($"Площадь круга = {string.Format("{0:f0}", sofcircle)}, максимальная цифра = {GetMaxDigit(sofcircle)}");
