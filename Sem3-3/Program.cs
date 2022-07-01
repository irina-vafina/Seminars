// Напишите программу, которая принимает на вход число (N)
// и выдаёт квадраты чисел от 1 до N.

void Quad(int x)
{
    int current = 1;
    while (current <= x)
    {
        int quad = current*current;
        Console.Write(quad+ " ");
        current ++;
    }
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Quad (n);