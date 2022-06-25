int num1, num2, max;

Console.Write ("Imput a first number:  ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Imput a second number:  ");
num2 = Convert.ToInt32(Console.ReadLine());

max = num1;

if (num1>max) max = num1; 
if (num2>max) max = num2;

Console.WriteLine ("Max = " +max);
