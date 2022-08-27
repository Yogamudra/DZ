/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
//Console.clear();
Console.WriteLine("Input number");
int a = int.Parse(Console.ReadLine());
int b = a / 10;
int c = b % 10;
Console.WriteLine("Second dijit: "+c);
