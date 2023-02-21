// See https://aka.ms/new-console-template for more information


Console.Clear();
Console.WriteLine("Ввведите число: ");
int number = int.Parse(Console.ReadLine()!);
int result = 0;

if (number < 100)
{
    Console.WriteLine("третий цифры нет: ");
}
else
{
    while (number >= 1000)
    {
        number = number / 10;
    }
    result = number %10;
    Console.WriteLine(result);
}
