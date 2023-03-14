// Задайте двумкрный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
/* Например, задан массив
1 4 7 2 
5 9 2 3
8 4 2 4 
Итог
8 4 2 4 
5 9 2 3
1 4 7 2
*/
Console.Clear();
Console.WriteLine("Введите количество строк:");
int m =int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число минимального и максимального значения :");
int minValue =int.Parse(Console.ReadLine());
int maxValue =int.Parse(Console.ReadLine());
int[,]array=Masiv(m,n,minValue,maxValue);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите строку 1:");
int a1 = int.Parse(Console.ReadLine());
Console.Write("Введите строку 2:");
int b1 = int.Parse(Console.ReadLine());
ZamenaMestami(array,a1,b1);
PrintArray(array);

int[,]Masiv(int m,int n,int minValue, int maxValue)
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

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void ZamenaMestami(int[,] Array, int a, int b)
{
    for( int i=0; i<Array.GetLength(1); i++)
    {
        int k=Array[a-1,i];
        Array[a-1,i]=Array[b-1,i];
        Array[b-1,i]=k;
    }
}