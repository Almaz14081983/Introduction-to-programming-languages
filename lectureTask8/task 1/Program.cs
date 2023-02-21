// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Ввведите Х: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("Ввведите y: ");
int y = int.Parse(Console.ReadLine()!);

if (x > 0 && y > 0)
{
    Console.Write("1 четверть");
}
if (x < 0 && y > 0)
{
    Console.Write("2 четверть");
}
if (x < 0 && y < 0)
{
    Console.Write("3 четверть");
}
if (x > 0 && y < 0)
{
    Console.Write("4 четверть");
}