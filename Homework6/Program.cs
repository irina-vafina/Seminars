// Метод, создающий массив из вещественных элементов заполненный данными пользователя

int [] CreateArray (int size) 
{
    int[] newArray = new int [size]; 
  
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} число: "); 
        newArray[i] = Convert.ToInt32(Console.ReadLine());        
    }
    Console.WriteLine();      
    return newArray;
}

// Метод, показывающий, выводящий массив из вещественных элементов на экран, печатающий его. 

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");         
    }
    Console.WriteLine( );
}
 

// Метод, считающий числа массива больше нуля.

int NumCollZero(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >0) count++;
    }
    return count;
}


// метод находящий точку пересечения двух отрезков

int IntersectionPoint (int b1, int b2, int k1, int k2)
{
    if ((k1 * b2 - k2 * b1) == 0) Console.WriteLine("Прямые параллельны");
    else 
    {
        int x = (b1 - b2) / (k1 - k2);
        int y = k2 * x + b2;
        return (x, y);
    }
}



//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


Console.Write("Сколько чисел будете вводить?: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);
Console.WriteLine("Количество чисел больше 0: " + NumCollZero(array));


//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

int point = IntersectionPoint (b1, b2, k1, k2);
Console.WriteLine(point);

//Console.WriteLine(IntersectionPoint (b1, b2, k1, k2));