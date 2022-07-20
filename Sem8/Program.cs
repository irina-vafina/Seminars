//Метод, создающий случайный двумерный массив случайных значений.
int[,] CreateRandom2dArray1(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

//Метод, создающий заданный пользователем двумерный массив.Aij = i+j

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
    Console.WriteLine();
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
/*
int[,] FindQvad(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)

            if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];

    return array;
}

int[,] newArray = new int[rows,columns];
for (int i = 0; i < length; i++)
*/

// метод, заменяет сроки на столбцы, массив должен быть квадрат, иначе сообщ для пользователя
int[,] Reverse2dArray1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    return array;
}


int[,] Reverse2dArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Number of roms and columns is not the same!");
        return array;
    }

    for (int i = 0; i < array.GetLength(0) - 1; i++)
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }

    return array;
}

// заполняет 0 строку и столбец на пересеч кот располож мин элемент
int[,] Cut2dArray(int[,] array)
{
    int iMin = 0, jMin = 0;   //находим индекс мин элемента

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }

    for (int j = 0; j < array.GetLength(1); j++) // присваиваем 0 значение элементам в строке и столбце с мин инд
        array[iMin, j] = 0;                      //элементам с минимальным i, идем по столбцам
    for (int i = 0; i < array.GetLength(0); i++)
        array[i, jMin] = 0;                       //элементам с минимальным j, идем по cтрокам

    return array;
}


//меняет местами первую и последнюю строку массива
int[,] Change2dArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[0, j];
            array[0, j] = array[array.GetLength(0) - 1,j];
            array[array.GetLength(0) - 1,j] = temp;
        }
    return array;    
}






//Задача2:
//Задайте двумерный массив. Напишите программу, которая заменяет строки
//на столбцы. В случае, если это невозможно, программа должна вывести 
//сообщение для пользователя.
/*
Console.Write("Imput number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);

Show2dArray(myArray);
Show2dArray(Reverse2dArray(myArray));
*/
//Задача3:
//Из двумерного массива целых чисел удалить строку и столбец, на 
//пересечении которых расположен наименьший элемент.
/*
Console.Write("Imput number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Show2dArray(Cut2dArray(myArray));
*/


//Задача1:
//Задайте двумерный массив. Напишите программу, которая поменяет местами 
//первую и последнюю строку массива


Console.Write("Imput number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Show2dArray(ChangeArray(myArray));                      
