//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
// mas = [[1, 2, 3],
//  [4, 5, 6]]
// mas[0][2]
using System;
using static System.Console;

Clear();
Write("");
int m=int.Parse(ReadLine());
Write("");
int n=int.Parse(ReadLine());

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
