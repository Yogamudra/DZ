/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] GetArray(int m, int n)
{
    int[,] a = new int[m, n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            a[i,j] = new Random().Next(1, 10);
        }
    }
    return a;
}
void PrintArray (int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine(" Vvedtite kolvo strok");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine(" Vvedtite kolvo stolbcov");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < array.GetLength(1); j++) {
    double sum = 0;
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++) {
        sum = array[i, j] + sum;
        n++;
    }
        Console.Write(Math.Round((sum / n), 2) + ", ");
}
Console.WriteLine();
Console.WriteLine();