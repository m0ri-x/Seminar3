// Задача 20. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A по оси x");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по оси y");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки А по оси z");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси x");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси y");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси z");
double zB = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

Console.WriteLine($"Расстояние между двумя точками в пространстве равно {result}");