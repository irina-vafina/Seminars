//Метод, создающий случайный двумерный массив случайных значений.
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

//Метод, создающий заданный пользователем двумерный массив.

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


//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами.
/*Console.Write("Imput number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
*/


//Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
Console.Write("Imput number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine("Sum of main diagonal is " + FindDiagSum(myArray));
*/


//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: 
//Aij = i+j. Выведите полученный массив на экран.
/*
Console.Write("Imput number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(m, n);
Show2dArray(myArray);
*/


//Задайте двумерный массив. Найдите элементы, у которых 
//оба индекса чётные, и замените эти элементы на их квадраты.

/*
Console.Write("Imput number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine();
myArray = FindQvad(myArray);
Show2dArray(myArray);
*/
