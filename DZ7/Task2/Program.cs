/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] GetArray(int m, int n) {
  int[,] result = new int[m, n];
  for (int i = 0; i < m; ++i) {
    for (int j = 0; j < n; ++j) {
      result[i, j] = new Random().Next(1, 100);
    }
  }
  return result;
}
void PrintArray(int[,] array) {
  for (int i = 0; i < array.GetLength(0); ++i) {
    for (int j = 0; j < array.GetLength(1); ++j) {
      Console.Write($" {array[i, j]}");
    }
    Console.WriteLine();
    }
}
Console.WriteLine(" Vvedtite chislo");
int d = int.Parse(Console.ReadLine());
int c = 0;
Console.WriteLine(" Vvedtite kolvo strok");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine(" Vvedtite kolvo stolbcov");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); ++i) 
{
    for (int j = 0; j < array.GetLength(1); ++j)
    {
        if (array[i,j] == d)
        {
        c = d;
        }
    }
}
Console.WriteLine();
if (c != d)
{
Console.WriteLine(d + " -> There is no such number in the array");
}
else
{
    Console.WriteLine(d + " -> There is such a number in the array'");
}