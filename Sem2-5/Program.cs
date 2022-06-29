// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.

void IsQuad(int num1, int num2)
{
    int quad2 = num2*num2;
    int quad1 = num1*num1;

    if(num1 == quad2)
        Console.WriteLine("Yes");
    else
        if(num2 == quad1)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
}
