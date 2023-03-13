/*  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Введите числа через пробел:");
string elements=Console.ReadLine()!;
Console.Clear();
int[] baseArray=GetARRAYfromString(elements!);
Console.WriteLine(String.Join(" ",baseArray));
Console.WriteLine($"Чисел больше нуля=>{Count(baseArray)}");

int [] GetARRAYfromString(string stringArray)//Новая фигня
 {
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);//!!!!!!!!!!!
    int[] res =new int [nums.Length];
    for( int i=0; i< nums.Length; i++)
    {
        res[i]=int.Parse(nums[i]);
    }
    return res;
 }

 int Count(int []array)
 {
    int count=0;
    foreach( int el in array)
    {
        if(el>0){count++;}
    }
    return count;
 }