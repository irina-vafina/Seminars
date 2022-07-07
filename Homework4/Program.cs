// Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

void SumKol(int[] array) 
{
    int count = array.Length;
    int summ = 0;

     for (int i = 0; i < count; i++)
    {
        summ = summ + array[i];
    }
    
    Console.Write($"Сумма цифр числа {summ}");
}
   
Console.WriteLine("ВВедите число: ");
int arr = Convert.ToInt32(Console.ReadLine());

SumKol(arr);



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