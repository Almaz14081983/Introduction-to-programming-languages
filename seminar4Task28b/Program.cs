// Напишите программу , которая принимает на вход 
// число N и выдает произведение чисел от 1 до N 
// 4->24
// 5-.120

Console.Clear();
Console.Write("Введите число:  ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"произведение чисел = {ProductOfNumbers(num)}");

int ProductOfNumbers(int number)
{
    int prod = 1;
    for (int count = 1; count <=number; count ++) 
    {
       prod = prod*count;
    }
    return prod;
}
// Console.Write(prod);
