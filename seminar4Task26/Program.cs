// задача 26. напишите программу , которая принимает
// на вход число и выдает количество цифр в числе.
// 456->3
// 78->2
// 89126->5

Console.Clear();
Console.Write("Введите число:  ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"количество цифр в числе = {NumberDigits(num)}");

int NumberDigits(int number)
{
    int count = 1;
    while( number > 10)
    {
        number = number / 10;
        count = count + 1;
    }
    return count;
}
