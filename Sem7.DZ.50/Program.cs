/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.Clear();
Console.WriteLine("Введите число m и n:");
int m =int.Parse(Console.ReadLine()!);
int n =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число минимального и максимального значения :");
int minValue =int.Parse(Console.ReadLine()!);
int maxValue =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите искомое число:");
int N =int.Parse(Console.ReadLine()!);
int[,]array=Masiv(m,n,minValue,maxValue);
PrintArray(array);
Result(array,N);

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

void Result(int[,]array,int num)
{
    int count=0;
    for (int i = 0; i <array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j]==num)
                {
                    count++;
                }
            }
        }
   if(count>0){Console.WriteLine($"Число {num} присутствует. ");}
    else{Console.WriteLine($"Число {num} отсутствует. ");}
}
