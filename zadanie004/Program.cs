/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Clear();
int evenNumber =2;
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

if (num1 > 1)
{
    while(evenNumber<=num1)
    {
        Console.Write(evenNumber+",");
        evenNumber = evenNumber+2;
    }
}
