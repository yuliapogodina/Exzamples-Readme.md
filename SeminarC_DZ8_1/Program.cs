// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк массива");
int sizeRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int sizeColumns = Convert.ToInt32(Console.ReadLine());

double[,] array = FillArray(sizeRows, sizeColumns);

PrintArray(array);

double[,] array1 = SortStringArray(array);

PrintArray(array1);

double[,] FillArray(int sizei, int sizej)
{
    Random random = new Random();
    double[,] resultArray = new double[sizei, sizej];
    for (int i = 0; i < sizei; i++)
    {
        for (int j = 0; j < sizej; j++)
            resultArray[i, j] = Math.Round(random.NextDouble() * random.Next(0, 101), 1);
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

double[,] SortStringArray(double[,] inputArray)
{
    double[] tempArray = new double[inputArray.GetLength(1)];
    double[,] outArray = new double[inputArray.GetLength(0), inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++) tempArray[j] = inputArray[i, j];
        Array.Sort(tempArray);
        Array.Reverse(tempArray);
        for (int j = 0; j < inputArray.GetLength(1); j++) outArray[i, j] = tempArray[j];
    }
return outArray;
}