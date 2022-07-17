//Метод, создающий случайный двумерный массив случайных значений.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}


//Метод, создающий случайный двумерный массив случайных значений.

void FillArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(1,10);
}


//Метод, создающий заданный пользователем двумерный массив по формуле Aij = i+j

int[,] Create2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = i + j;

    return newArray;
}


//Метод выводящий на экран двумерный массив.

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}


//Метод выводящий на экран двумерный массив double.

void Show2dArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}


//метод находящий сумму чисел на главной диагонали

int FindDiagSum1(int[,] array)
{
    int sum = 0;

    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == j) sum += array[i, j];
            }
        }
    }
    return sum;
}

//тот же метод после упрощения
int FindDiagSum(int[,] array)
{
    int sum = 0;

    if (array.GetLength(0) == array.GetLength(1))
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, i];

    return sum;
}


//метод находящий элементы, у которых оба индекса чётные,
//заменяющий эти элементы на их квадраты.

int[,] FindQvad(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)

            if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];

    return array;
}


//Метод, на вход принимает позиции элемента в двумерном массиве, и возвращает значение
//этого элемента или же указание, что такого элемента нет

void Array2d(int a, int b, int[,] array)
{
    int num2d = 0;
    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)

            //if(a = array[i,0] && b = array[0,j]) num2d = array[i,j];
            if(a = array[i,] && b = array[,j]) num2d = array[i,j];
            Console.WriteLine(num2d);
          
            else 
            Console.WriteLine("такого элемента нет");
}


void ArithmeticMean(int[,] array)
{
    int am1, am2, am3, am4;
    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)

            am1 = (array[0,0]+array[1,0]+array[2,0])/3;
            am2 = (array[0,1]+array[1,1]+array[2,1])/3;
            am3 = (array[0,1]+array[1,2]+array[1,3])/3;
            am4 = (array[0,3]+array[1,3]+array[2,3])/3;
            
            Console.Write ($"Среднее арифметическое стобцов:{am1}, {am2}, {am3}, {am4}");
}



//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4. 
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
Console.Write("Imput number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min possible value: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput max possible value: ");
double max = Convert.ToDouble(Console.ReadLine());

double[,] myArray = CreateRandom2dArrayDouble(m,n,min,max);
Show2dArrayDouble(myArray);
*/
//Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение
//этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
/*
Console.Write("Введите позицию элемента, номер строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента, номер столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,]matrix = new int[3,4];
FillArray(matrix);
Show2dArray(matrix);
Array2d(a, b, matrix);
*/


//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,]matrix = new int[3,4];
FillArray(matrix);
Show2dArray(matrix);
ArithmeticMean(matrix);










