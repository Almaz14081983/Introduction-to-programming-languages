//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
//Определение. Произведением двух матриц А и В называется матрица С, 
//элемент которой, находящийся на пересечении i-й строки и j-го столбца, 
//равен сумме произведений элементов i-й строки матрицы А 
//на соответствующие (по порядку) элементы j-го столбца матрицы В.
//

Console.Clear();  
Console.Write("Введите количество строк матрицы A: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов матрицы A и строк матрицы B: "); 
int rowscol = int.Parse(Console.ReadLine()!); 

Console.Write("Введите количество столбцов матрицы B: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное значение чисел в матрицах: ");
int min = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное значение чисел в матрицах: ");
int max = int.Parse(Console.ReadLine()!);

void GetArray(int[,] someArray) 
{ 
    for (int i = 0; i < someArray.GetLength(0); i++)
    { 
        for (int j = 0; j < someArray.GetLength(1); j++) 
        { 
            someArray[i, j] = new Random().Next(min, max + 1); 
        } 
     } 
}

int[,] martrixA = new int[rows, rowscol];

int[,] martrixB = new int[rowscol, columns];

int[,] martrixC = new int[rows, columns];


void MatrixProduct(int[,] martrixA, int[,] martrixB, int[,] martrixC)
{
    for (int i = 0; i < martrixC.GetLength(0); i++)
    {
        for (int j = 0; j < martrixC.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < martrixA.GetLength(1); k++)
            {
                sum = sum + (martrixA[i,k] * martrixB[k,j]);
            }
            martrixC[i,j] = sum;
        }
    }
}

void PrintArray(int[,] inArray) 
{ 
    for (int i = 0; i < inArray.GetLength(0); i++) 
    { 
        for (int j = 0; j < inArray.GetLength(1); j++) 
        { 
            Console.Write($"{inArray[i, j]} "); 
        } 
        Console.WriteLine(); 
    } 
} 

GetArray(martrixA);
PrintArray(martrixA);
GetArray(martrixB);
Console.WriteLine();
PrintArray(martrixB);
MatrixProduct(martrixA, martrixB, martrixC);
Console.WriteLine($"Произведение двух матриц:");
PrintArray(martrixC);
