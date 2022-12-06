//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

Console.Clear();

int[] array = FillArray(5, 0, 10);
int[] array2 = FindProductElementArray(array);

Console.WriteLine($"Получившийся массив: [{string.Join(",", array)}]");
Console.WriteLine($"Получившийся массив: [{string.Join(",", array2)}]");

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

int[] FindProductElementArray(int[] inputarray)
{
    int k = (inputarray.Length % 2 == 0 ? k = inputarray.Length / 2 : k = inputarray.Length / 2 + 1);
    int[] outArray = new int[k];
    if (inputarray.Length % 2 != 0) outArray[k] = inputarray[k];
    int i = inputarray.Length;
   for (int j = 0; j < k; j++)
   {
        outArray[j] = inputarray[j] * inputarray[i - j];
       j++;
        Console.Write(outArray[j]);
    }
    return outArray;
}
