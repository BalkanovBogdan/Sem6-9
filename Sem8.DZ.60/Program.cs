// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
Console.Clear();
int[,,] array = Masiv3D(2,3,4);
PrintArray(array);

int[,,]Masiv3D(int k, int m,int n)
{
    int[,,] result = new int[m, n, k];
    for (int z = 0; z < k; z++)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[z, i, j] = new Random().Next(10, 99);
            }
        }
    }    
    return result;
}

void PrintArray(int[,,] Array)
{
    for (int z = 0; z < Array.GetLength(0); z++)
    {
        for (int i = 0; i < Array.GetLength(1); i++)
        {
            for (int j = 0; j < Array.GetLength(2); j++)
            {
                Console.Write($"{Array[z,i,j]} ");
            }
            Console.WriteLine();
        }
    Console.WriteLine();
    }
}