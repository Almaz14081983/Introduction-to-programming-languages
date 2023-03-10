// Задача 69: Напишите программу, которая на вход принимает
// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число: ");
int userInput = int.Parse(Console.ReadLine()!)!;
Console.Write("Введите степень: ");
int userPow = int.Parse(Console.ReadLine()!)!;
Console.WriteLine($"{RecursePow(userInput, userPow)}");

int RecursePow(int inNum, int pow)
{
    if (pow == 1)
    {
        return inNum;
    }
    else
    {
        return inNum * RecursePow(inNum, pow - 1);
    }
}

