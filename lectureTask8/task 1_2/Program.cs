// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Ввeдите Х = ");
int X = int.Parse(Console.ReadLine());
Console.Write("Ввeдите Y = ");
int Y = int.Parse(Console.ReadLine());

if ((X > 0) & (Y > 0)) Console.WriteLine("Координаты находятся в 1 - ой четверти");

if ((X < 0) & (Y > 0)) Console.WriteLine("Координаты находятся вo 2 - ой четверти");

if ((X < 0) & (Y < 0)) Console.WriteLine("Координаты находятся в 3 - eй четверти");

if ((X > 0) & (Y < 0)) Console.WriteLine("Координаты находятся в 4 - eй четверти");

