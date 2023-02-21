// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите число  ");
int a1 = int.Parse(Console.ReadLine()!);
int a2 = a1/10;
int a3 = a2%10;
// int a2 = num%10;
Console.WriteLine("вторая цифра: " + a3);

