// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int i;
int max;
int[] nums = new int[3];
i = 0;
max = 0;
Console.WriteLine("Необходимо ввести 3 числа");
while (i < 3)
{
    i++;
    Console.WriteLine($"Ведите число {i}");
    nums[i - 1] = Convert.ToInt32(Console.ReadLine());
    if (nums[i-1]>max)
    {
        max = nums[i-1];
    }
}
Console.WriteLine($"Максимальное значение: {max}");
