// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите число1 ");
double number1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
double number2 = double.Parse(Console.ReadLine()!);

if(number1 > number2)
{
    Console.WriteLine("max = " + number1);
    Console.WriteLine("min = " + number2);
}
else
{
    Console.WriteLine("max = " + number2);
    Console.WriteLine("min = " + number1);
}
