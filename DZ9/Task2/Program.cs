/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.*/

Console.Clear();
Console.WriteLine("Enter value M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter value N");
int n = int.Parse(Console.ReadLine());

int f(int m, int n)
{
if (n == m) return m;
else return n + f(m, n - 1);
}
Console.WriteLine("M = " + m + "; N = " + n + ". -> " + f(m,n));