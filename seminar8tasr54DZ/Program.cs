//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.Clear();  
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: "); 
int columns = int.Parse(Console.ReadLine()!); 


int[,] GetArray(int m, int n, int min, int max) 
{ 
    int[,] result = new int[m, n]; 
    for (int i = 0; i < m; i++) 
    { 
        for (int j = 0; j < n; j++) 
        { 
            result[i, j] = new Random().Next(min, max + 1); 
        } 
     } 
    return result; 
} 



void SortArray(int[,] inArray) 
{ 
    for (int i = 0; i < inArray.GetLength(0); i++) 
    { 
        for (int j = 0; j < inArray.GetLength(1); j++) 
        { 
             for (int n = 0; n < inArray.GetLength(1)-1; n++)
            {                
                if (inArray[i,n] < inArray[i,n+1]) 
                { 
                    int num = inArray[i,n+1]; 
                    inArray[i,n+1] = inArray[i,n]; 
                    inArray[i,n] = num; 
                } 
            }
            
        } 
    } 
    Console.WriteLine();  
    Console.Write("В итоге получается вот такой массив: ");
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


int[,] array = GetArray(rows, columns, -10, 10); 
PrintArray(array); 
SortArray(array); 
Console.WriteLine();
PrintArray(array);




