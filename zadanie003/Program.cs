/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);
int result = (num1 % 2);
if (result == 0)
{
    Console.WriteLine("да");
}
else Console.WriteLine("нет");
