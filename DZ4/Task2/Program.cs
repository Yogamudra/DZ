/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear();
Console.WriteLine("Input number");
int a = int.Parse(Console.ReadLine());
int x = a;
int i = 0;
int sum = 0;
int n = 0;
if (a < 0)
    {
        a = Math.Abs(a);
    }
while (a > 0)
    { 
        n = a % 10;
        a = a / 10;
        sum = sum + n;
        i++;
    }
Console.WriteLine("Сумма цифр в числе " + x + " -> " + sum);
