// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координаты точки А, Xa = ");
double Xa = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки А, Ya = ");
double Ya = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки A, Za = ");
double Za = double.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки B, Xb = ");
double Xb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки B, Yb = ");
double Yb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки B, Zb = ");
double Zb = double.Parse(Console.ReadLine()!);

double sqrab = ((Xb - Xa)*(Xb - Xa) + (Yb - Ya)*(Yb - Ya) + (Zb - Za)*(Zb - Za));
double result = Math.Sqrt(sqrab);
double rounded = Math.Round(result,2);

Console.Write($"расстояние между двух точек {rounded}");

