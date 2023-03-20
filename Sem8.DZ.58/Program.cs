// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
Console.Clear();
Console.WriteLine("Введите число строк и столбцов:");
int m =int.Parse(Console.ReadLine()!);
int n = m;
Console.WriteLine("Введите число минимального и максимального значения :");
int minValue =int.Parse(Console.ReadLine()!);
int maxValue =int.Parse(Console.ReadLine()!);
int[,] array1 = Masiv(m,n,minValue,maxValue);
int[,] array2 = Masiv(m,n,minValue,maxValue);
Console.Clear();
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(Proizvedenie(array1,array2));

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

int [,] Proizvedenie(int [,] array1, int [,] array2)
{
    int [,] result = new int [array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {      
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            int sum = 0;
            for(int l = 0; l < array1.GetLength(1); l++)
            {
                sum += array1[i,l] * array2[l,j];
            }
            result[i,j] = sum; 
        } 
    }
    return result;
}