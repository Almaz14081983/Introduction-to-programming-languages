// задача 24. напишите программу , которая
// принимает на вход число (А) и выдает сумму чисел
// 1 до А
// 7->28
// 4->10
// 8->36

Console.Clear();
Console.Write("Введите число:  ");
int num = int.Parse(Console.ReadLine()!);

int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0 )
    {
        sum = sum + number;
        number = number - 1;
    }
    return sum;
}
Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");