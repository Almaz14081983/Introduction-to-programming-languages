// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//  5 -> 1, 4, 9, 16, 25.
//  2 -> 1,4

Console.Clear();
Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);


int num = 1;
while (num <= N)
{
    Console.Write(num*num + " , ");
    num++;
}
Console.Write(num*num + ". ");
