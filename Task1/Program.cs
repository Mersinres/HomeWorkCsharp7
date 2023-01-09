//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.

Int32 k, l, m, n;
Console.Write("задайте размер двумерного массива через пробел : ");
string [] a = Console.ReadLine().Split(" ");
m = Convert.ToInt32(a[0]);
n = Convert.ToInt32(a[1]);
Random rnd = new Random();

for (k = 0; k < m; k++)
{
    for (l = 0; l < n; l++)
    {
        double[,] ar = new double[m, n];
        ar[k, l] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        Console.Write(ar[k, l]);
    }
  
    Console.WriteLine();
} 