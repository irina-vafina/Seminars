// Метод, генерирующий массив из целочисленных элементов
// вызванных случайным образом

int [] CreateRandomArray (int size, int minValue, int maxValue) // в скобках аргументы, состав массива (длина, макс и мин элементы)
{
    int[] newArray = new int [size]; // инициализация массива newArray

    for(int i = 0; i < size; i++)  //i+=2 если по четным элементам должен идти
    {
       newArray[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return newArray;
}

// Метод, создающий массив из целочисленных элементов вызванных случайным образом
// элементы массива положительные, трехзначные.

int [] CreateThreeRandomArray (int size) 
{
    int[] newArray = new int [size]; 

    for(int i = 0; i < size; i++) 
    {
       newArray[i] = new Random().Next(100, 999); 
    }
    return newArray;
}

// Метод, создающий массив из целочисленных элементов
// заполненный данными пользователя

int [] CreateArray (int size) 
{
    int[] newArray = new int [size]; // [] т.к. возвращается массив

    Console.WriteLine("Creating array here: ");     // создание массива здесь
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");         // введите текущий элемент, +1 т.к. пользователь ведет учет с 1 элемента, а массив с 0        newArray[i] = Convert.ToInt32(Console.ReadLine); 
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();      // строка для разделения, пустая строка
    return newArray;
}

// Метод, показывающий, выводящий массив на экран, печатающий его.
// ничего не должен возвращать, только распечатать, поэтому void

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");         // вывод элементов в строку
    }
    Console.WriteLine( );
}
 
// Метод, находящий сумму положительных элементов массива.

int FindPositiveSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) sum += array[i];
    }
    return sum;
}

// Метод, находящий сумму элементов, стоящих на нечетных позициях (индексы)

int FindOddSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i+=2)
    {
        if(i % 2 == 0) sum += array[i]; // if(i % 2 != 0) - проверка на нечетность. но пользователи считают с 1, а не с 0.
    }
    return sum;
}

// Метод, заменяющий знак элемента массива на противоположный

int[] ReversArray(int[] newArray) // название и нов массив
{   
    for (int i = 0; i < newArray.Length; i++)
    { 
        newArray[i] = newArray[i]*-1;
    }
    return newArray;
}

// Метод, находящий кол-во элементов массива находящихся в отрезке [10, 99]

int FindTwoDigits(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >=10 && array[i] <= 99) count++;
    }
    return count;
}

// Метод, находящий кол-во четных элементов массива

int FindEven(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

//ДЗ Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*Console.Write("Intut size of array: ");
int siz = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateThreeRandomArray(siz);
ShowArray(arr);
Console.WriteLine("Count of even elements is " + FindEven(arr));
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
Console.Write("Intut size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Intut min possidle vaiue of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Intut max possidle vaiue of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRandomArray(size, min, max);
ShowArray(arr);

int sumOdd = FindOddSum(arr);
Console.WriteLine("Sum of elements in odd positions " + sumOdd);
*/


//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


// не решила



// вызываем массив из случайных элементов
/*
Console.Write("Intut size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Intut min possidle vaiue of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Intut max possidle vaiue of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
// вызываем массив из данных пользователя saze возьмем тот же, что и в первом случае
int[] array2 = CreateArray(size);

// отображаем массивы
ShowArray(array1);
ShowArray(array2);
*/


// Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму положительных элементов массива

/*Console.Write("Intut size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Intut min possidle vaiue of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Intut max possidle vaiue of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int sumOfPositive = FindPositiveSum(array);
Console.WriteLine("Sum of positiv elements in current array is " + sumOfPositive);
*/

// 1 Напишите программу замены элементов массива: положительные элементы замените
// на соответствующие отрицательные, и наоборот.

/*Console.Write("Intut size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Intut min possidle vaiue of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Intut max possidle vaiue of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr1 = CreateRandomArray(size, min, max);
ShowArray(arr1);
int[] array2 = ReversArray(arr1);
ShowArray(array2);
*/

// 2 Задайте одномерный массив из 20 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].

/*int size = 20;
Console.Write("Intut min possidle vaiue of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Intut max possidle vaiue of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("Count of two-digit elements is " + FindTwoDigits(array));
*/
