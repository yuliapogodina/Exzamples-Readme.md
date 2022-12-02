//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int[] IntCoord(int n)
{
    int[] coord = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Ведите координату: ");
        coord[i] = Convert.ToInt32(Console.ReadLine());
    }
    return coord;
}

Console.WriteLine("Точка 1");
int[] point1 = IntCoord(3);
Console.WriteLine("Точка 1");
int[] point2 = IntCoord(3);

double SumSqrValue(int[] a, int[] b)
{
    double sum = 0;
    for (int j = 0; j < point1.Length; j++)
    {
        sum = Math.Pow((point1[j] - point2[j]), 2) + sum;
    }
    sum = Math.Sqrt(sum);
    return sum;
}
double result = SumSqrValue(point1, point2);
Console.Write($"Расстрояние между точками = {string.Format("{0:f1}", result)}");
