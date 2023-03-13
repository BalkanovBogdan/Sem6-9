// Напишите программу, которая перевернет одномерный массив.
Console.Clear();
int [] result=Masiv(10);
Console.WriteLine(String.Join(" ",result));
PrintArray(result);
Revers(result);
PrintArray(Revers(result));
Console.WriteLine(String.Join(" ",Revers(result)));

int[] Masiv(int size)
{
    int n=10;
    int[]res=new int[size];
    for( int i=0;i<size;i++)
    {
        res[i]=n+i;
    }
    return res;
}

int []Revers(int[]array)
{
    int[]res=new int[array.Length];
    //int[]res2=array;
    for(int i=0;i<array.Length;i++)
    {
        res[i]=array[array.Length-1-i];//res2 был место array

    }
    return res;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
