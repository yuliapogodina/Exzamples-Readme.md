// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет

Console.Clear();
Random random = new Random();
int sizeRows = random.Next(1, 10);
int sizeColumns = random.Next(1, 10);

Console.WriteLine("Введите номер строки массива от 0 до 9:");
int elementRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца массива от 0 до 9:");
int elementColumn = Convert.ToInt32(Console.ReadLine());

double[,] array = FillArray(sizeRows, sizeColumns);

PrintArray(array);

if (elementRow >= sizeRows || elementColumn >= sizeColumns) Console.WriteLine("Такого элемента нет в массиве");
else Console.WriteLine($"элемент на позиции {elementRow},{elementColumn} = {array[elementRow, elementColumn]}");

double[,] FillArray(int sizei, int sizej)
{
    Random random = new Random();
    double[,] resultArray = new double[sizei, sizej];
    for (int i = 0; i < sizei; i++)
    {
        for (int j = 0; j < sizej; j++)
            resultArray[i, j] = Math.Round(random.NextDouble() * random.Next(-100, 101), 1);
    }
    return resultArray;
}

void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}