/*  Задайте двумерный массив.
    Напишите программу, которая заменяет строки на столбцы.
    В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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
Zamena(array);
PrintArray(Zamena(array));

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

int[,] Zamena(int[,] Array)
{
    int[,]result=new int[Array.GetLength(1),Array.GetLength(0)];
    for (int i = 0; i <Array.GetLength(0); i++)
    {
         for (int j = 0; j < Array.GetLength(1); j++)
        {
            result[j,i] = Array[i,j];
        }
    }
    return result;
}