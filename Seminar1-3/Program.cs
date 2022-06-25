int num1, num2, quad;

Console.Write ("Imput a first number:  ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Imput a second number:  ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2*num2;
if (quad == num1 )
{
    Console.WriteLine ("First number is quat of secohd number");
}
else 
{
    Console.WriteLine ("First number is not quat of secohd number");
}

