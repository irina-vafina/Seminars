// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

void Palindrome(int num)
{
    if(num > 9999 && num < 100000)
    {
        if(num[0] = num[4] && num[1] = num[3]) 
        {
            Console.WriteLine("Это число является палиндромом");
        }
        else
            Console.WriteLine("Это число не является палиндромом");
    }
    else 
        Console.WriteLine("Ошибка, число не пятизначное");
}

Console.Write("Введите пятизначное число: ");
int numPalinr = Convert.ToInt32(Console.ReadLine());
Palindrome (numPalinr);
