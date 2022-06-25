int n, current;

Console.Write ("Imput a number:  ");
n = Convert.ToInt32(Console.ReadLine());

current = 1;

while (current <=n||current%2==0)
{
    Console.Write (current+ " ");
    current ++;  
}
