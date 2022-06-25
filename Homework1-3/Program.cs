int num, even;

Console.Write ("Imput a number:  ");
num = Convert.ToInt32(Console.ReadLine());

even = num/2;
if (num%2==0)
{
    Console.WriteLine ("Yes");
}
else 
{
    Console.WriteLine ("No");
}
