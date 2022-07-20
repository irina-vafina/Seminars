int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

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

int[,] NumbersInOrder(int[,] array)
{
    int jMin = 0;   //находим индекс j мин элемента строки
    
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++) // идем по столбцам чтобы отсортировать в строке
        {
            if (array[0, j] < array[0, jMin]) jMin = j;
        }

            for (int j = 0; j < array.GetLength(1); j++) // перемещаем в начало мин элемент
            {
                int temp = array[0, jMin];
                array[0, jMin] = array[0, j];
                array[0, j] = temp;
            }
    return array;

}

void FindSumRows(int[,] array)
{
    int minSum = 0;

    int minSum1=array[0,0]+array[0,1]+array[0,2];
    int minSum2=array[1,0]+array[1,1]+array[1,2];
    int minSum3=array[2,0]+array[2,1]+array[2,2];
    int minSum4=array[3,0]+array[3,1]+array[2,2];

    minSum1 = minSum; Console.WriteLine("Строка 1");
    if(minSum2<minSum1) minSum2 = minSum; Console.WriteLine("Строка 2");
    if(minSum3<minSum2) minSum3 = minSum; Console.WriteLine("Строка 3");
    if(minSum4<minSum3) minSum4 = minSum; Console.WriteLine("Строка 4");

}


/*
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8
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
Show2dArray(NumbersInOrder(myArray));
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int m = 3;
int n = 4;
int min = 0;
int max = 9;

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
FindSumRows(myArray);

*/

//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

/*
int [,] array = new int[4,4];
array[0,0] = 1;
array[0,1] = 2;
array[0,2] = 3;
array[0,3] = 4;
array[1,0] = 12;
array[1,1] = 13;
array[1,2] = 14;
array[1,3] = 5;
array[2,0] = 11;
array[2,1] = 16;
array[2,2] = 15;
array[2,3] = 6;
array[3,0] = 10;
array[3,1] = 9;
array[3,2] = 8;
array[3,3] = 7;
Console.WriteLine(array);
*/



















