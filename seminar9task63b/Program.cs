// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите N: ");
int userN = int.Parse(Console.ReadLine()!)!;

NaturalNumbers(userN);

void NaturalNumbers(int n)
{
//    Console.Write($" {n}, ");
//    Console.Write($" n");
    if (n == 0)
    {
        return;
    }
    else // Console.WriteLine(".");
    {
        NaturalNumbers(n - 1);
    }
    Console.Write($"{n}, ");
}


