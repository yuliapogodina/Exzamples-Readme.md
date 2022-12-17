// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.WriteLine("Введите количество строк матрицы 1");
int sizeRows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы 1");
int sizeColumns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк матрицы 1");
int sizeRows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы 1");
int sizeColumns2 = Convert.ToInt32(Console.ReadLine());

double[,] matrix1 = FillArray(sizeRows1, sizeColumns1);
double[,] matrix2 = FillArray(sizeRows2, sizeColumns2);
double[,] matrix3 = new double[sizeColumns1, sizeRows2];
PrintArray(matrix1);
PrintArray(matrix2);

if (sizeColumns1 != sizeRows2) Console.WriteLine("Матрицы не согласованы, перемножение невозможно");
else
{
    matrix3 = ProductArray(matrix1, matrix2);
    Console.WriteLine("Результат произведения двух матриц");
    PrintArray(matrix3);
}

double[,] FillArray(int sizei, int sizej)
{
    Random random = new Random();
    double[,] resultArray = new double[sizei, sizej];
    for (int i = 0; i < sizei; i++)
    {
        for (int j = 0; j < sizej; j++)
            resultArray[i, j] = Math.Round(random.NextDouble() * random.Next(-10, 11), 0);
    }
    return resultArray;
}

void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"|" + inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] ProductArray(double[,] inputArray1, double[,] inputArray2)
{
    double[,] outMatrix = new double[inputArray1.GetLength(0), inputArray2.GetLength(1)];
    for (int i = 0; i < inputArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray2.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray2.GetLength(0); k++)
            {
                outMatrix[i, j] += inputArray1[i, k] * inputArray2[k, j];
            }
        }
    }
    return outMatrix;
}