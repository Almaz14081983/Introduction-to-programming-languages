// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.  
// A (3,6); B (2,1) -> 5,09  
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.Write("Введите координаты точки А, Xa = ");
double Xa = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки А, Ya = ");
double Ya = double.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки B, Xb = ");
double Xb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки B, Yb = ");
double Yb = double.Parse(Console.ReadLine()!);

double sqrab = ((Xb - Xa)*(Xb - Xa) + (Yb - Ya)*(Yb - Ya));
double result = Math.Sqrt(sqrab);
double result2 = Math.Round(result,2);
// double result2 = result%1000;

Console.Write($"расстояние между ними {result2}");
