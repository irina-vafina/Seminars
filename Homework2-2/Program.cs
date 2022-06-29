// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.



/*int ThirdNumber()
{

    Console.Write ("Введите число:  ");
    int num = Convert.ToInt32(Console.ReadLine());

    int third = num[2];
    return third;
    
}

int number = ThirdNumber();
Console.WriteLine(number);
*/

int ThirdNumber()
{

    Console.Write ("Введите число:  ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 99)
    {
        int third == num [3];

    }
    
    Console.Write ("Третья цифра:  ");
    return third;
    
    else
    {
        Console.Write ("Третьей цифры нет");
    }
}

