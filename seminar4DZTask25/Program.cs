// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.Write($"рузультат = {NumberDegree(A, B)}");

int NumberDegree(int numberA, int numberB)
{
    int count = 1;
    int num = 1;
    while (count <= numberB)
    {
        num = num*numberA;
        count++;
    }
    return num;
}
