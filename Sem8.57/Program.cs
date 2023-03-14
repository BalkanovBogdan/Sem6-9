/*  Составьте частотный словарь элементов двумерного массива.
    Частотный словарь содержит информацию о том, 
    сколько  раз встречается элемент входных данных.
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
Console.Write("Введите искомое число:");
int num =int.Parse(Console.ReadLine());
Poisk(array,num);
int [] rowar = GetRowArray(array);
Sortarray(rowar);
Console.WriteLine(String.Join(" ", rowar));
PrintData(rowar);

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

void Poisk(int[,] Array, int a)
{
    int count=0;
    int num=a; 
    for (int i = 0; i <Array.GetLength(0); i++)
    {
         for (int j = 0; j < Array.GetLength(1); j++)
        {
            if(num == Array[i,j])
            {
                count++;
            }
        }
    }
    Console.WriteLine($"{a} встречается {count} раз");
}

int [] GetRowArray(int[,] inArray)
{
    int[] result = new int [inArray.GetLength(0) * inArray.GetLength(1)];
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i,j];
            index++;
        }
    }
    return result;
}

void Sortarray(int[] inArray)//  Пузырьковый метод сортировки
{
    for(int i = 0; i < inArray.Length; i++)
    {
        for(int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

void PrintData(int[] inArray)
{
    int el = inArray[0];
    int count = 1;
    for (int i =1; i < inArray.Length; i++)
    {
        if(inArray[i] != el)
        {
            Console.WriteLine($"{el} встречается {count}");
            el = inArray[i];
            count=1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{el} Встречается {count}");
}