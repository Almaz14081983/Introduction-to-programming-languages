﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число  ");
int a1 = int.Parse(Console.ReadLine());
if((1<=a1) & (a1<=5))
{
    Console.WriteLine("нет");
}
if((6<=a1) & (a1<=7))
{
    Console.WriteLine("да");
}

