//Задача 53: Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку
//массива.

Console.Clear();

Console.Write("Введите колличество строк массива  ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите колличество столбцов массива  ");
int columens = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное значение в массиве ");
int min = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное значение в массиве ");
int max = int.Parse(Console.ReadLine()!);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int [m,n];
    for(int i = 0; i < m; i ++)
    {
        for(int j = 0; j < n; j ++)
        {
            result[i,j] = new Random().Next(min, max+1);
        }
    }
    return result;
}

void ArithmMean(int[,] matrix)
{
//    int m = 0;
//    int n = matrix.GetLength(0)-1;
    for(int i = 0; i < matrix.GetLength(1); i ++)
    {
        int arr = matrix[0, i];
        matrix[0, i] = matrix[(matrix.GetLength(0)-1), i];
        matrix[(matrix.GetLength(0)-1), i] = arr;
    } 
}

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray( rows, columens, min, max);
PrintArray(array);
ArithmMean(array);
Console.WriteLine();
PrintArray(array);