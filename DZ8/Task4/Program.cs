//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// первый вариант
Console.Clear();
int s = 11;
int[,,] GetArray(int rows, int columns, int pallets)
{
    int[,,] array = new int[rows, columns, pallets];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < pallets; k++)
            {
                array[i, j, k] = s;
                s = s + 1;
            }
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine(" Set dimension 1");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine(" Set dimension 2");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine(" Set dimension 3");
int pallets = int.Parse(Console.ReadLine());
int[,,] array = GetArray(rows, columns, pallets);
PrintArray(array);
Console.WriteLine(); 