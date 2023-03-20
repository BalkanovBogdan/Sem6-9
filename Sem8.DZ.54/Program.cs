// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();
Console.WriteLine("Введите количество строк:");
int m =int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число минимального и максимального значения :");
int minValue =int.Parse(Console.ReadLine());
int maxValue =int.Parse(Console.ReadLine());
int[,]array=Masiv(m,n,minValue,maxValue);
Console.Clear();
PrintArray(array);
Console.WriteLine();
Uporodochit(array);
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

void Uporodochit(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for(int q = 0; q < array.GetLength(1); q++)
        {
            for(int l = q + 1; l < array.GetLength(1); l++)
            {
                if (array[i,q] < array[i,l])
                {
                    int k = array[i,q];
                    array[i,q] = array[i,l];
                    array[i,l] = k;
                }
            }
        }    
    }
}
