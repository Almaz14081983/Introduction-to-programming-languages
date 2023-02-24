// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear(); 
Console.Write("Введите N: ");
int numbersN = int.Parse(Console.ReadLine()!)!;

 NaturalNumbersDescending(numbersN);

void  NaturalNumbersDescending(int num)
{
    Console.Write($"{num}, ");
    if (num == 1)
    {
        return;
    }
    else 
    {
        NaturalNumbersDescending(num - 1);
    }
}



