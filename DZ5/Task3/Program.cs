/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();
double n = 0;
double max = 0;
double min = 99;
int[] a = new int[5];
Random b = new Random();
for (int i=0; i <5; i++)
 {
 a[i] = b.Next(0, 99);
 }
Console.WriteLine(string.Join(", ", a));
for (int i = 0; i < a.Length; i++) 
{
if (a[i] <= min) min = a[i];
if (a[i] > max) max = a[i];
    n = max - min;
}
Console.WriteLine(Math.Round(min, 2) + " -> min");
Console.WriteLine(Math.Round(max, 2) + " -> max");
Console.WriteLine(Math.Round(n, 2) + " -> Разница между максимальным и минимальным элементами массива");