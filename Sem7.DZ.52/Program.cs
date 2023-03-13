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
double [,] result =Masiv(m,n);
PrintArray(result);
Arif(result);


double[,]Masiv(int m,int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 9);
        }
    }
    return result;
}
void PrintArray(double[,] Array)
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
double[] Arif(double[,]array)
{
    double [] res = new double [m];
    for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                if()
                {
                    sum+=res;
                }
            }
        }
}