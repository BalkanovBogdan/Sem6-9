// Напишите программу, которая принимает на вход три числа и проверяет, может ли 
// существовать труеугольник с сторонами такой длинны.

Console.Clear();
Console.WriteLine("Введите три числа через пробел: ");
string[] st = Console.ReadLine().Split(' ');
int a=int.Parse(st[0]);
int b=int.Parse(st[1]);
int c=int.Parse(st[2]);

if(Boolbool(a,b,c)){Console.WriteLine("да");}
else{Console.WriteLine("Нет");}
bool Boolbool(int a, int b, int c)
{
    return(((a+b)>c) && ((a+c)>b) && ((b+c)>a));
}
