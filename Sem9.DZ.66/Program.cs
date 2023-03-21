/* Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
using System;
using static System.Console;
Clear();
Write("Введите начальное значение : ");
int M = int.Parse(ReadLine()!);
Write("Введите конечное значение :  ");
int N = int.Parse(ReadLine()!);
WriteLine(Metod( M, N ));

int Metod(int M, int N)
{
    if(M == N + 1)
        return 0;
    return(M + Metod(M + 1, N));
}