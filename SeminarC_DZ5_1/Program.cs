//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.Clear();
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, 100, 1000);
Console.WriteLine($"Получившийся массив: [{string.Join(",", array)}]");

Console.WriteLine($"Количество четных элементов в массиве: {FindCountEventAndUneventByArray(array).Item1}");
Console.WriteLine($"Количество нечетных элементов в массиве: {FindCountEventAndUneventByArray(array).Item2}");


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

(int, int) FindCountEventAndUneventByArray(int[] inputArray)
{
    int eventValues = 0;
    int uneventValues = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] %2 == 0)
            eventValues++; 
        else
            uneventValues++;
    }
    return (eventValues, uneventValues);
}