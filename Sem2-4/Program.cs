// Напишите программу, которая принимает на вход число 
//и проверяет, кратно ли оно одновременно 7 и 23.

/*
bool Second_task_1(int numberTask2)
{
Console.Write ("Imput a number:  ");
if (numberTask2 % 7 == 0 && numberTask2 % 23 == 0)
    return true;
else
    return false;
}

int task2 = Convert.ToInt32(Console.ReadLine());
Second_task_1(task2);
*/

void NymKrat()
{
    Console.Write ("Imput a number:  ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 7 == 0)
    {
        if(num % 23 == 0)
        {
            Console.WriteLine ("Yes");
        }
        else
        {
            Console.WriteLine ("No");
        }
    }    
    else 
    {
        Console.WriteLine ("No");
    }
}

NymKrat();
