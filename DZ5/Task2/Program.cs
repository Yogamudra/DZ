/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
int[] a = new int[4];
Random b = new Random();
for (int i=0; i <4; i++)
 {
 a[i] = b.Next(0, 99);
 }
Console.WriteLine(string.Join(",", a));
int sum = 0;
for (int i = 0; i < 4; i++)
    {
        sum += a[i] % 2 > 0 ? a[i]: 0;
    }
Console.WriteLine("В массиве [" + (string.Join(",", a) + "] сумма нечетных чисел -> " + sum));