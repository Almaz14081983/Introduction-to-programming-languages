// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(0,100);
        index++; 
    }
    Console.Write(String.Join(", ",(array)) + " -> ");
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        position++;
    }
    Console.Write("["+String.Join(", ",(array))+"]");
}

