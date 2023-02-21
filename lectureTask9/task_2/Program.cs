// Напишите программу, которая будет принимать на вход два числа и выводить, является ли втрое число кратным первому. 
// если число 2 не кратно числу 1 выводить информацию и остаток от деления.
// 34, 5 - не кратно, остаток 4
// 16, 4 - кратно.

Console.Clear();
Console.WriteLine("Введите число 1  ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2  ");
int num2 = int.Parse(Console.ReadLine());

int rem = num1%num2;
if(rem == 0)
{
    Console.WriteLine($"число {num2} кратно {num1} ");
}
else
{
    Console.WriteLine($"число {num2} не кратно {num1}, остаток {rem} ");
}
 
