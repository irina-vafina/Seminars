// Напишите программу, которая выводит случайное число 
//из отрезка [10, 99] и показывает наибольшую цифру числа.

int MaxNumber()
{
    int num = new Random().Next(10, 100);
    Console.WriteLine("Current random number is "+ num);
    
    int firstNum = num % 10;
    int secondNum = num / 10;

    if (firstNum > secondNum)
        return firstNum;
    else 
        return secondNum;
}

int result = MaxNumber();
Console.WriteLine("Result is " + result);