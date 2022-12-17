// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите размерность массива");
int sizeRows = Convert.ToInt32(Console.ReadLine());
int sizeColumns = sizeRows;

double[,] array = FillArray(sizeRows, sizeColumns);

PrintArray(array);

Console.WriteLine($"Строка с наименьшей суммой элементов: {FindMinSumStringArray(array)}");

double[,] FillArray(int sizei, int sizej)
{
    Random random = new Random();
    double[,] resultArray = new double[sizei, sizej];
    for (int i = 0; i < sizei; i++)
    {
        for (int j = 0; j < sizej; j++)
            resultArray[i, j] = Math.Round(random.NextDouble() * random.Next(0, 101), 0);
    }
    return resultArray;
}

void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
            Console.Write($"|" + inputArray[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindMinSumStringArray(double[,] inputArray)
{
    double minsum = 0;
    int imin=0;
    for (int j = 0; j < inputArray.GetLength(1); j++) minsum += inputArray[0, j];

    for (int i = 1; i < inputArray.GetLength(0); i++)
    {
        double sumString = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++) sumString += inputArray[i, j];
        if (sumString < minsum)
        {
            minsum = sumString;
            imin = i;
        }
    }
    return imin;
}