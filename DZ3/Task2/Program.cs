/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Input number N");
int N = int.Parse(Console.ReadLine());
int i = 1;
Console.Write(N+"-->");
N = Math.Abs(N);
while (i<=N)
{
    Console.Write(Math.Pow(i,3)+",");
    i++;
}