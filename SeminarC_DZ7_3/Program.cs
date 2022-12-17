// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Random random = new Random();
int sizeRows = random.Next(2, 6);
int sizeColumns = random.Next(2, 6);

double[,] array = FillArray(sizeRows, sizeColumns);

PrintArray(array);

Console.WriteLine("Среднеарифметическое столбцов:");

Console.WriteLine($"{string.Join("\t|", MidleSumColumn(array))}");

//Console.Write(MidleSumColumn(array));

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
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write("|" + inputArray[i, j] + "\t");
        }
        Console.WriteLine(Environment.NewLine);
    }
}

double[] MidleSumColumn(double[,] inputArray)
{
    double[] s = new double[inputArray.GetLength(1)];

    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++) s[j] = s[j] + inputArray[i, j];

        s[j] = Math.Round(s[j] / inputArray.GetLength(1), 1);
    }

    return s;
}