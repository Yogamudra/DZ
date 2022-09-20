/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear();
Console.WriteLine("Input number A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input number B");
int b = int.Parse(Console.ReadLine());
int i = 0;
while (i == 0)
{
    Console.Write(a + ", " + b + " -> " + Math.Pow(a, b));
        i++;
}