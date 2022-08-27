/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */
Console.WriteLine("Input number day");
int number1 = int.Parse(Console.ReadLine());
switch (number1)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Not a holiday");
        break;
    case 6:
        Console.WriteLine("Yes, Saturday");
        break;
    case 7:
        Console.WriteLine("Yes, Sunday");
        break;
}