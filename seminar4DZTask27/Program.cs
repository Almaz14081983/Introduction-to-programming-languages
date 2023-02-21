// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int sum = int.Parse(Console.ReadLine()!);
Console.WriteLine($"сумма цифр в числе {SumDigitsNumber(sum)}");

int SumDigitsNumber(int num)
{
    int result = 0;
    int count = 1;
    while (num > 0)
    {
        int num1 = num%10;
        num = num/10;
        result = result + num1;
        count = count+1;
    }
    return result;
}
