//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = FillArray(size);
Console.WriteLine($"Получившийся массив: [{string.Join(",", array)}]");
Console.WriteLine($"Максимальное и минимальное значениями массива: {FindMinAndMaxByArray(array).Item2} и {FindMinAndMaxByArray(array).Item1}");
Console.WriteLine($"Разница между максимальным и минимальным значениями = {FindMinAndMaxByArray(array).Item2 - FindMinAndMaxByArray(array).Item1}");

double[] FillArray(int sizeArray)
{
    Random random = new Random();
    double[] resultArray = new double[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        //resultArray[i] = random.NextDouble()*100;
        resultArray[i] = Math.Round(random.NextDouble()*random.Next(-1000, 1001), 0);
    }
    return resultArray;
}

(double, double) FindMinAndMaxByArray(double[] inputArray)
{
    double minValues = inputArray[0];
    double maxValues = inputArray[0];
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] > maxValues)
            maxValues = inputArray[i];
        else if (inputArray[i] < minValues)
            minValues = inputArray[i];
    }
    return (minValues, maxValues);
}