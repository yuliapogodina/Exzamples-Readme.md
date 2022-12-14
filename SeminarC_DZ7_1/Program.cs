// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.WriteLine("Введите количество строк массива");
int sizeRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int sizeColumns = Convert.ToInt32(Console.ReadLine());

double[,] array = FillArray(sizeRows, sizeColumns);

PrintArray(array);
//Console.WriteLine($"Получившийся массив: [{string.Join(",", array)}]");

double[,] FillArray(int sizei, int sizej)
{
    Random random = new Random();
    double[,] resultArray = new double[sizei,sizej];
    for (int i = 0; i < sizei; i++)
    {
        for (int j = 0; j < sizej; j++)
        resultArray[i,j] = Math.Round(random.NextDouble()*random.Next(-100, 101), 1);
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