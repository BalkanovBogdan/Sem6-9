// Напишите программу, которая на вход принимает два числа А и В,
// и возврощает число А в целую степень В с помощью рекурсии.

using System;
using static System.Console;

Clear();
Write("Введите число: ");
int a = int.Parse(ReadLine()!);
Write("Введите число степени: ");
int b = int.Parse(ReadLine()!);
WriteLine($"{Recurs(a, b)}");

int Recurs(int number, int stepen)
{
    if (stepen == 0)
        return 1;
    return ( number * Recurs(number, stepen - 1));
}