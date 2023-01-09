// // Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите строку: ");
int i1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбик: ");
int i2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 3; 
int m = 4; 
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(10, 99);
    Console.Write("{0} ", arr[i, j]);
}
    Console.WriteLine();
}
    if (i1 < 0 | i1 > arr.GetLength(0) - 1 | i2 < 0 | i2 > arr.GetLength(1) - 1)
{
    Console.WriteLine("Такого эллемента не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[i1, i2]);
}
Console.ReadLine();