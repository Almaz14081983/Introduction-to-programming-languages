// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти = ");
int quarter = int.Parse(Console.ReadLine()!);

if ((quarter >4) || (quarter <1)) Console.Write("нет четверти: ");

if (quarter == 1) Console.Write("x > 0 , y > 0 ");
if (quarter == 2) Console.Write("x < 0 , y > 0 ");
if (quarter == 3) Console.Write("x < 0 , y < 0 ");
if (quarter == 4) Console.Write("x > 0 , y < 0 ");

