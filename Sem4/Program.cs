// сем Напишите программу, которая принимает на вход число
// (А) и выдаёт сумму чисел от 1 до А.
/*
int FindSum(int a)
{
    int sum = 0;

    for (int current = 1; current <= a; current++)
        sum += current; // sum = sum + current
    
    return sum;
}

Console.WriteLine("ВВедите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма номеров от 1 до {num} есть {FindSum(num)}");
*/


// 1 Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.

//1-1
/*
int Kolich(int num)
{
    int result = 1;
    int i = 1;
    while(num/i>10)
    {
        i=i*10;
        result++;
    }
    return result;
}

Console.WriteLine("ВВедите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Kolich(n));
*/

//1-2
/*
int Numbers(int a)
{
    int i = 0;
    if(i <= a)
    {
        while(a>0)
        {
            a=a/10;
            i= i+1;
        }
    }
    return i;
}

Console.WriteLine("ВВедите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Numbers(n));
*/

//2 Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.

//2-1
/*
int FindP(int a)
{
    int p = 1;

    for (int current = 1; current <= a; current++)
        p *= current; // p = p * current
    
    return p;
}

Console.WriteLine("ВВедите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Произведение номеров от 1 до {num} есть {FindSum(num)}");
*/
// 2-2
/*
int Proisv(int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
        result = result*i; 
    
    return result;
}

Console.WriteLine("ВВедите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Proisv(n));
*/


//3 Напишите программу, которая принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
/*
int FindP(int a, int b)
{
    int result = 1;

    for (int i = 0; i <= b; i++)
    {
        result = result*a;
    }
             
    return result;
}

Console.WriteLine("Введите число А: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {num1} в степени {num2} равно {FindP(num1,num2)}");
*/
