// Задача 64: Задайте значение N. Напишите программу, которая найдет 
//кол-во цифр в числе N рекурсивным методом.
// N = 4532 -> 4


// int CountNum(int n)
// {
//     if (n / 10 != 0)
//         return 1 + CountNum(n / 10);
//     else
//         return 1;
// }

// Console.Write("Введите N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write(CountNum(num));

// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



// int SumOfDidits(int m, int n)
// {
//     if (n > m)
//     {
//        return m + SumOfDidits(m,n -1);
//     }
//     return n;
// }

// Console.Write("Введите N: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите N: ");
// int n= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumOfDidits(m,n));

