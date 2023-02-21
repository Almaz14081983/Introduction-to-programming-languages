// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear ();
Console.Write("Ввведите номер четверти: ");
int quarter  = int.Parse(Console.ReadLine()!);
if ((quarter >4) || (quarter <1))
{
    Console.Write("нет четверти: ");
}
else
{
    if(quarter ==1)
    {
        Console.Write("В первой четверти х>0, y>0.");
    }
    if(quarter ==2)
    {
        Console.Write("В второй четверти х<0, y>0.");
    }
    if(quarter ==3)
    {
        Console.Write("В третьей четверти х<0, y<0.");
    }
    if(quarter ==4)
    {
        Console.Write("В четвертой четверти х>0, y<0.");
    }
}
