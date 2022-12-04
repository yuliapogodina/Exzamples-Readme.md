Console.Clear();

Console.Write("Введите размерность масива:");
int arrlenhgt = Convert.ToInt32(Console.ReadLine());

int[] FillingArray(int n)
{
    Random rnd = new Random();
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(0, 10);
    }
    return arr;
}

int[] arr = FillingArray(arrlenhgt);
Console.WriteLine(String.Join(",", arr));