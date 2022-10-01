/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.*/
Console.Clear();
Console.WriteLine("Enter value M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter value N");
int n = int.Parse(Console.ReadLine());
void AllNaturalNumbers(int m, int n) 
{
    if (m == n)
    {
    Console.WriteLine($"{m}");
    return;
    }
    if (m < n) 
    {
        Console.Write($"{m},");
        AllNaturalNumbers(m + 1, n);
    }
    if (m > n) 
    {
        Console.Write($"{n},");
        AllNaturalNumbers(m, n + 1);
    }
}
Console.Write("M -> " + m + "; N -> " + n + ". -> ");
AllNaturalNumbers(m, n);