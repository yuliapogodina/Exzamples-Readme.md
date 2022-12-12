//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите несколько чисел через пробел");

string text = Convert.ToString(Console.ReadLine() ?? " ");

int GetCountPositiveNumbers(string stringOfNumbers)
{
    string[] words = stringOfNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    int i = 0;
    int number;
    foreach (string s in words)
    {
        number = Convert.ToInt32(s);
        if (number > 0) i++;
    }
    return i;
}
Console.WriteLine(GetCountPositiveNumbers(text));