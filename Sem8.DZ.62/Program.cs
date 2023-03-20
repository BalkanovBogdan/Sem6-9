// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
/*  01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07 */
Console.Clear();
int [,] array = Masiv(4,4);
PrintArray(array);


int[,]Masiv(int m,int n)
{
    int count = 1;
    int[,] result = new int[m, n];
    int a = result.GetLength(0);
    int b = result.GetLength(1);
    for (int i = 0; i < a; i++)
    {
       
        for (int j = 0; ;j++)
        {
            if(j < b)
            {
                result[i, j] = count++;

            }
            else
            {
                int k = result.GetLength(0);
                a = result.GetLength(1);
                b = k;
            }
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