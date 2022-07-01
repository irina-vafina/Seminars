// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

void СubeNum (int num)
{
    int current = 1;

    while(current <= num)
    {
        int cube = current*current*current;
        Console.Write(cube + " ");
        current ++;
    }
}

Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
СubeNum (n);
