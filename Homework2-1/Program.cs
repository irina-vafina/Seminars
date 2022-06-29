// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

int SecondNumber()
{
    Console.Write ("Введите трехзначное число:  ");
    int num = Convert.ToInt32(Console.ReadLine());
        
    if(99 < num)
    {
        if(num < 1000)
        {
            int ten = (num / 10) % 10;
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
    
    int result = ten;
    return result;
}

int res = SecondNumber();
Console.WriteLine("Result is " + res);



/*/вводит случайное 3х значное число и удаляет вторую цифру этого числа.
//через int возвращает значение.
int CutNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is "+ num);
    
    int sotni = num / 100;
    int ed = num % 10;

    int result = sotni*10 + ed;
    return result;
}

int number = CutNumber();
Console.WriteLine("Result is " + number);\
*/