/* Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/
Console.Clear();
int[,] GetArray(int rows1, int columns1) 
{
    int[,] array1 = new int[rows1,columns1];
        for (int i = 0; i < rows1; i++) 
        {
            for (int j = 0; j < columns1; j++) 
            {
                array1[i,j] = new Random().Next(1,10);
            }
        }    
        return array1;
}
void PrintArray(int[,] array1) 
{
    for (int i = 0; i < array1.GetLength(0); i++) 
    {
        for (int j = 0; j < array1.GetLength(1); j++) 
        {
                Console.Write($" {array1[i,j]}");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Enter the number of rows of the first matrix");
int rows1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns of the first matrix");
int columns1 = int.Parse(Console.ReadLine());
int[,] array1 = GetArray(rows1, columns1);
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Enter the number of rows of the second matrix");
int rows2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns of the second matrix");
int columns2 = int.Parse(Console.ReadLine());
int[,] array2 = GetArray(rows2, columns2);
PrintArray(array2);
Console.WriteLine();
int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
for (int i = 0; i < array3.GetLength(0); i++) 
{
    for (int j = 0; j < array3.GetLength(1); j++) 
    {
        for (int e = 0; e < array2.GetLength(1); e++) 
        {
            array3[i,j] += array1[i,e] * array2[e, j];
        }
    }
}
PrintArray(array3);
Console.WriteLine();