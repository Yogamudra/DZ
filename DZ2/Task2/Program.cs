/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
Console.WriteLine("Input number");
int a = int.Parse(Console.ReadLine());
int l = 0;
if (a < 100)
{
    Console.WriteLine("The third digit is missing");
}
else
{
    while (a > 1000)
    {
        a = a / 10;
    }
    l = a % 10;
    Console.WriteLine("Third dijit: "+ l);
}

