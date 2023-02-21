// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// Создаем еще один массив за счет существующих методов 
// и потом складываем их между собой.
// [1, 0, 1, 1, 0, 1, 0, 0]

Console.Clear();

int[] arr = new int[8];
int[] arr2= new int[8];
int[] arr3= new int[8];

RandomArray(arr);
PrintArray(arr);
Console.WriteLine(" ");

RandomArray(arr2);
PrintArray(arr2);
Console.WriteLine(" ");

SumArr(arr, arr2, arr3);
PrintArray(arr3);
Console.WriteLine(" ");
Console.WriteLine(" ");

void RandomArray(int[] numbers)
{
    for(int i = 0; i < 8; i++) 
    {
        numbers[i] = new Random().Next(0,2);
    }
}

void PrintArray(int[] array)
{
    for(int j = 0; j < 8; j++) 
    {
        Console.Write(array[j] + ", ");
    }
}

void SumArr(int[] array1, int[] array2, int[] array3)
{
    for(int d = 0; d < 8; d++) 
    {
        array3[d] = array1[d] + array2[d];
    }
}