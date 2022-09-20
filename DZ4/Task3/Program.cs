/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.Clear();
int[] a = new int[8];
Random b = new Random();
for (int i=0; i <8; i++)
 {
 a[i] = b.Next(0, 10);
 /*Console.WriteLine(a[i]);*/
 }
Console.Write(" -> [ ");
for (int i = 0; i < 8; i++)
{
    Console.Write($"{a[i]}, ");
}
Console.WriteLine("]");