// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

int SecondNumber()
{
    Console.Write ("Введите трехзначное число:  ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    if(num > 99)
    {
        if(num < 1000)
        {
            int ten = (num / 10) % 10;
            return ten;
        }
        else
        {
            Console.Write ("ОШИБКА, число не трехзначное");
        }
    }
    else
    {
        Console.Write ("ОШИБКА, число не трехзначное");
    }
    
}

int res = SecondNumber();
Console.WriteLine(res);

