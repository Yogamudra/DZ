/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.*/

Console.Clear();
Console.WriteLine("Enter value M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter value N");
int n = int.Parse(Console.ReadLine());
int A(int m, int n)
{
 if(m == 0) return n + 1;
 if(m > 0 && n == 0) return A(m-1, 1);
 if(m > 0 && n > 0) return A(m-1,A(m, n-1));
 
 else return A(m, n);
}
A(m,n);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) =  {A(m, n)}");