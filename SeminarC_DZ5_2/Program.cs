//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);
Console.WriteLine($"Получившийся массив: [{string.Join(",", array)}]");

Console.WriteLine($"Сумма элементов с четным индексом в массиве: {FindSumEventAndUneventIndexByArray(array).Item1}");
Console.WriteLine($"Сумма элементов с нечетным индексом в массиве: {FindSumEventAndUneventIndexByArray(array).Item2}");


int[] FillArray(int sizeArray, int minValue, int maxValue)
{
    Random random = new Random();
    int[] resultArray = new int[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue + 1);
    }
    return resultArray;
}

(int, int) FindSumEventAndUneventIndexByArray(int[] inputArray)
{
    int sumEventIndex = 0;
    int sumUneventIndex = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (i % 2 == 0)
            sumEventIndex += inputArray[i];
        else
            sumUneventIndex += inputArray[i];
    }
    return (sumEventIndex, sumUneventIndex);
}