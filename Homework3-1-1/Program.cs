// 2 вариант решения задачи 1

void Palindrome(int num)
{
    num = array [a,b,c,d,e];
    if(num > 9999 && num < 100000)
    {
        if(a = e && b = d) 
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
int numPalindr = Convert.ToInt32(Console.ReadLine());
Palindrome (numPalindr);
