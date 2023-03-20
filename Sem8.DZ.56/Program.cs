//  Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
Console.WriteLine("Введите количество строк:");
int m =int.Parse(Console.ReadLine());
int n = m*2;
Console.WriteLine("Введите число минимального и максимального значения :");
int minValue =int.Parse(Console.ReadLine());
int maxValue =int.Parse(Console.ReadLine());
int[,]array=Masiv(m,n,minValue,maxValue);
Console.Clear();
PrintArray(array);
minSum(array);

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

void minSum(int[,]array)
{
    int k = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          sum += array[i,j];
        }
        Console.WriteLine($"{i+1} Строка с суммой={sum};");
        if(i == 0)
        {
            k = sum;
        }
        if(sum < k)
        {
            k = sum;
            index = i;
        }
    }
    Console.WriteLine($"{index+1} Строка с наименьшей суммой={k};");
}