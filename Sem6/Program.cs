// Метод, генерирующий, создающий массив из целочисленных элементов 
//вызванных случайным образом

int[] CreateRandomArray(int size, int minValue, int maxValue) // в скобках аргументы, состав массива (длина, макс и мин элементы)
{
    int[] newArray = new int[size]; // инициализация массива newArray

    for (int i = 0; i < size; i++)  //i+=2 если по четным элементам должен идти
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}


// Метод, создающий массив из целочисленных элементов вызванных случайным образом
// элементы массива положительные, трехзначные.

int[] CreateThreeRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
    }
    return newArray;
}


// Метод, создающий массив из целочисленных элементов 
//заполненный данными пользователя

int[] CreateArray(int size)
{
    int[] newArray = new int[size]; // [] т.к. возвращается массив

    Console.WriteLine("Creating array here: ");     // создание массива здесь
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");         // введите текущий элемент, +1 т.к. пользователь ведет учет с 1 элемента, а массив с 0        newArray[i] = Convert.ToInt32(Console.ReadLine); 
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();      // строка для разделения, пустая строка
    return newArray;
}


// Метод, создающий массив из вещественных элементов 
//заполненный данными пользователя

double[] CreateArrayDouble(int size)
{
    double[] newArray = new double[size];

    Console.WriteLine("Creating array here: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

// Метод, показывающий, выводящий массив из вещественных элементов на экран, печатающий его. 

void ShowArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


// Метод, показывающий, выводящий массив на экран, печатающий его.
// ничего не должен возвращать, только распечатать, поэтому void

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");         // вывод элементов в строку
    }
    Console.WriteLine();
}


// Метод, находящий сумму положительных элементов массива.

int FindPositiveSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }
    return sum;
}


// Метод, находящий сумму элементов, стоящих на нечетных позициях (индексы)

int FindOddSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i += 2)
    {
        if (i % 2 == 0) sum += array[i]; // if(i % 2 != 0) - проверка на нечетность. но пользователи считают с 1, а не с 0.
    }
    return sum;
}


// Метод, заменяющий знак элемента массива на противоположный

int[] ReversArray(int[] newArray) // название и нов массив
{
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = newArray[i] * -1;
    }
    return newArray;
}


// Метод, находящий кол-во элементов массива находящихся в отрезке [10, 99]

int FindTwoDigits(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}


// Метод, находящий кол-во четных элементов массива

int FindEven(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}


// Метод, находящий индекс минимального числа в массиве

void minPosition(int[] array)
{
    int minPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minPos]) minPos = i;
    }
    Console.WriteLine(minPos);
}


// Метод, находящий минимальное число в массиве

void minPosNum(int[] array)
{
    int minPos = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minPos) minPos = array[i];
    }
    Console.WriteLine("Min =  " + minPos);
}


// Метод, находящий максимальное число в массиве

void maxPosNum(int[] array)
{
    int maxPos = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxPos) maxPos = array[i];
    }
    Console.WriteLine("Max =  " + maxPos);
}

// Метод, находящий минимальное вещественное число в массиве

void minPosNumDouble(double[] array)
{
    double minPos = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minPos) minPos = array[i];
    }
    Console.WriteLine("Min =  " + minPos);
}


// Метод, находящий максимальное вещественное число в массиве

void maxPosNumDouble(double[] array)
{
    double maxPos = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxPos) maxPos = array[i];
    }
    Console.WriteLine("Max =  " + maxPos);
}


// Метод, находящий разницу между мах и мин с вещественными числами в массиве

void MaxMinDifferenceDouble(double[] array)
{
    double minPos = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minPos) minPos = array[i];
    }
    Console.WriteLine("Min =  " + minPos);

    double maxPos = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxPos) maxPos = array[i];
    }
    Console.WriteLine("Max =  " + maxPos);

    double result = maxPos - minPos;
    Console.WriteLine("Difference = " + result);
}


//Метод, разворачивающий массив.


int[] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    return array;

}

/*3
int i = 0, j = array.Length - 1; 
         while (i < j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        i++;
        j--;
    }
*//*    //1
    for (int i = 0; i < array.Length / 2; i++) // /2т.к. должны дойти только до середины
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
*//*2
int lastIndex = array.Length - 1;
for (int i = 0; i < array.Length / 2; i++) 
    {
        int temp = array[i];
        array[i] = array[lastIndex - i];
        array[lastIndex - i] = temp;
    }
    return array;
*/


//Метод переводящий десятичное число в двоичную систему

string ChangeDigitSystem(int num)
{
    string resultNumber = string.Empty;

    while(num>0)
    {
        resultNumber = num % 2 + resultNumber;
        num /=2; // то же самое, что и нум = нум/2
    }
    return resultNumber;
}

Console.WriteLine(ChangeDigitSystem(18));

/*
15/2-> 7 1
7/2 -> 3 1
3/2 -> 1 1
1/2 -> 0 1
15 -> 1111 // выписывается остаток от деления целочисленного числа
            // снизу вверх
18/2-> 9 0
9/2 -> 4 1
4/2 -> 2 0
2/2 -> 1 0
1/2 -> 0 1
18 -> 10010
*/

//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] myArray = {3, 5, 1, 8, 2, 9, 4};
myArray = ReverseArray(myArray);

for (int i = 0; i < myArray.Length; i++)
    Console.Write(myArray[i] + " ");
*/

//Напишите программу, которая принимает на вход три числа 
//и проверяет, может ли существовать треугольник с сторонами такой длины.
//a < b + c и т.д. каждая сторона не должна быть больше суммы других сторон




//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
//0 1 1 2 3 5 8- чтобы получить новое число нужно сложить два предыдущих.
