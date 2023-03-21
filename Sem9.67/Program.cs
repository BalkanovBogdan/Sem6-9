// Напишите программу, которая будет на вход число и возвращать сумму его цифр.
using System;
using static System.Console;

Clear();
Write("Введите число: ");
int n = int.Parse(ReadLine()!);
WriteLine($"{n} -> {SumNumbers(n)}");

/*
int sum = 0;
while( n > 0)
{
    sum += n % 10;
    n /= 10;
}
WriteLine($"{sum}");
*/

int SumNumbers(int number)
{
    if(number == 0)
        return 0;
    return (number % 10 + SumNumbers(number / 10));
}
