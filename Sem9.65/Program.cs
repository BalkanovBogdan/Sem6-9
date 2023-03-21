// Задайте значение M и N.
// Напишите программу , которая выведет все натуральные числа в промежутке от M до N.
Console.Clear();
Console.WriteLine("Введите начальное значение :");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конечное значение :");
int N = int.Parse(Console.ReadLine()!);
Metod(M,N);
/*for ( int i = M; i < N; i++)
{
    Console.Write($"{i}");
}
Console.WriteLine();
Console.WriteLine(Metod(M,N));*/


string Metod(int M, int N)
{
    if(N == M)
    {
        Console.WriteLine(N);
        return M.ToString();
    }
    string s = Metod(M ,N - 1) + " " + N.ToString();
    Console.WriteLine(s);
    return s;
}