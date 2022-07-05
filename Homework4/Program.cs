// Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

int Numbers(int a) // принимает число и выдает кол-во цифр в числе
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







int FindSum(int a) // принимает число, выдает сумму чисел от 1 до А.
{
    int sum = 0;

    for (int current = 1; current <= a; current++)
        sum += current; // sum = sum + current
    
    return sum;
}

Console.WriteLine("ВВедите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма номеров от 1 до {num} есть {FindSum(num)}");














//Напишите программу, которая задаёт массив из
// m элементов и выводит их на экран.

/*
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
*/