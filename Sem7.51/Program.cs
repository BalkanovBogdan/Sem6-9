// // Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
using System;
using static System.Console;

Clear();
Write("Введите число строк:");
int m=int.Parse(ReadLine()!);
Write("Введите число столбцов:");
int n=int.Parse(ReadLine()!);
int [,] array=GetArray(m,n);
PrintArray(array);
Mas(array);
Write($"{Mas(array)}");

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
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

int Mas(int[,] inArray)
{
    int sum=0;
for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if(i==j)
                {
                    sum+=inArray[i,j];
                }
            }
            
        }
return sum;
}
/*
int Mas(int[,]array)
{
    int GetLength;
    int length=array.GetLength(0)<array.GetLength(1)? array.GetLength(0):array.GetLength;
    int sum=0;
    for (int i = 0; i < length; i++)
    {
        sum+=array[i,i];
    }
   return sum; 
}
*/