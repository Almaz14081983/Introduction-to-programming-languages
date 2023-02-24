
// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"




Console.Clear(); 
Console.Write("Введите начальное число: ");
int first = int.Parse(Console.ReadLine()!)!;
Console.Write("Введите конечное число: ");
int last = int.Parse(Console.ReadLine()!)!;

NaturalNumbersString(last);

void NaturalNumbersString(int last)
{
    if (last == first-1)
    {
        return;
    }
    else 
    {
        NaturalNumbersString(last - 1);
    }
    Console.Write($"{last}, ");
}