// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
Console.Clear();
int[,,] array = Masiv3D(2,3,4);
PrintArray(array);

int[,,]Masiv3D(int k, int m, int n)
{
    int[,,] result = new int[k , m, n];
    for (int z = 0; z < k; z++)
    {
        for (int i = 0; i < m; i++)
        {
            int j = 0;
            while(j < n )
            {
                int el = new Random().Next(10, 99);
                if ( FindElement(result, el)) continue; 
                result[z, i, j] = el;
                j++;
            }
        }
    }    
    return result;
}

bool FindElement(int [,,] array, int el)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] Array)
{
    for (int z = 0; z < Array.GetLength(0); z++)
    {
        for (int i = 0; i < Array.GetLength(1); i++)
        {
            for (int j = 0; j < Array.GetLength(2); j++)
            {
                Console.Write($"{Array[z,i,j]} ({z},{i},{j})");
            }
            Console.WriteLine();
        }
    Console.WriteLine();
    }
}