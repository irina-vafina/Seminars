//вводит случайное 3х значное число и удаляет вторую цифру этого числа.
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
Console.WriteLine("Result is " + number);
