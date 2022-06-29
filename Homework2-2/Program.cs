// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.


void ThirdNumber()
{
    Console.Write ("Введите число:  ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 99)
    {
        int third == num[2];
        Console.Write ("Третья цифра:  " + third);
    } 
    else
    {
        Console.Write ("Третьей цифры нет");
    }
}

ThirdNumber();
