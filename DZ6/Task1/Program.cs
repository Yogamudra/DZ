/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

Console.Clear();
Console.Write("Set number of numbers  ");
int dimension = int.Parse(Console.ReadLine());
int[] array_set = new int[dimension];
for (int i=0; i < dimension; i++)
 {
  array_set[i] = int.Parse(Console.ReadLine());
 }
Console.WriteLine("Number of positive numbers = " + array_set.Count(x=>x>0));
