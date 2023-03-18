/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear();
Console.WriteLine("Введите число строк и столбцов");
int m=int.Parse(Console.ReadLine());
int n=int.Parse(Console.ReadLine());
int [,] result =Masiv(m,n);
PrintArray(result);
srArif(result);


int[,]Masiv(int m,int n)
{
    int [,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i, j] = new Random().Next(1, 9);
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
void srArif(int[,]array)
{
    int k = 0;
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
          sum+=array[j,i];
        }
        Console.WriteLine($"{i+1} столбец ср.арифметеческое={sum/m:0.00}; ");
        sum = 0;
    }
}