// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear(); 
Console.Write("Введите значение числа M: ");
int meaningM = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение числа N: ");
int meaningN = int.Parse(Console.ReadLine()!);

int SumMN(int numberM, int numberN)
{
    int res = numberM;
    if (numberM == numberN)
        return 0;
    else
    {
        numberM++;
        res = numberM + SumMN(numberM, numberN);
        return res;
    }
}
Console.WriteLine($"Cумма натуральных чисел в промежутке от M до N = {SumMN(meaningM-1, meaningN)}");
