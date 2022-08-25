/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
//Обрабатывается случай равенства 2 и 3 чисел
Console.WriteLine("Input first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Input third number");
int c = int.Parse(Console.ReadLine());
if (a == b && b == c)
{
    Console.WriteLine("All numbers are equal");
}
else
    if (a >= b)
    {
        if (a >= c)
        {
            Console.WriteLine("Maximum = " + a);
        }
        else 
        {
            Console.WriteLine("Maximum = " + c);
        }
    }
    else 
    {
        if (b >= c)
        {
            Console.WriteLine("Maximum = " + b);
        }
        else 
        {
            Console.WriteLine("Maximum = " + c);
        }
    }  