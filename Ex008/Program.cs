﻿/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.WriteLine("Введите число: ");
string numberA = Console.ReadLine();
int number = int.Parse(numberA);

int i = 1;
bool not = true;


while (i <= number)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}
