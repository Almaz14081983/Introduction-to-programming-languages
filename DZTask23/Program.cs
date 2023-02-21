// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);

int num = 1;
while (num < N)
{
    Console.Write(num*num*num + " , ");
    num++;
}
Console.Write(num*num*num + ". ");
