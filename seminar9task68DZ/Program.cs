 // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
 // Даны два неотрицательных числа m и n.
 // m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
 
  
Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int FunctionAkkerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numN == 0 && numM > 0)
    {
        return FunctionAkkerman(numM - 1, 1);
    }
    else
    {
        return (FunctionAkkerman(numM - 1, FunctionAkkerman(numM, numN - 1)));
    }
}
FunctionAkkerman(numberM, numberN);
Console.WriteLine($"A(m,n) = {FunctionAkkerman(numberM, numberN)}");