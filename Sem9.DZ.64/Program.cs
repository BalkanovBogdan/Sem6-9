/*  Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

using System;
using static System.Console;
Clear();
WriteLine("Введите значение N: ");
int n =int.Parse(ReadLine()!);
MetodRecurs(n);

string MetodRecurs(int number)
{
    int a = 1;
    if(number == a)
        return a.ToString();
    string s =  number.ToString() + " " + MetodRecurs(number - 1);
    WriteLine(s);
    return s;
}