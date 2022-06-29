//вводит случайное 3х значное число и удаляет вторую цифру этого числа. 
//через void не возвращает значение. вместо результата можно поставить Console.WriteLine("Result is " + num); 
void CutNumberVoil()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is "+ num);
    
    int sotni = num / 100;
    int ed = num % 10;

    int result = sotni*10 + ed;
    Console.WriteLine("Result is " + num);
   }

CutNumberVoil();
