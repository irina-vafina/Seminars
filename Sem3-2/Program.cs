// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер четверти плоскости, в которой находится эта точка.

int ShowQuart(int x, int y)
{
    int result = -1;
    
    if(x > 0 && y > 0) result = 1;
    if(x < 0 && y > 0) result = 2;
    if(x < 0 && y < 0) result = 3;
    if(x > 0 && y < 0) result = 4;

    return result;
}

Console.WriteLine("Введите координату х: ");
int x0 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите координату y: ");
int y0 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine (ShowQuart(x0, y0));
