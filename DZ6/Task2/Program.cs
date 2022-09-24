/* Задача 43: Напишите программу, которая найдёт  точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Input b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Input k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Input b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Input k2");
double k2 = double.Parse(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
if (k1 == k2)
    {
    Console.WriteLine(" Straight lines are parallel");
    }
else 
    if (b1 == b2 && k1 == k2)
    {
    Console.WriteLine(" Direct match");
    }
else
    {
    Console.WriteLine($"Points of intersection of two lines ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
    }
