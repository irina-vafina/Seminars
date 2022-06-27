int n, current;

Console.Write ("Imput a number:  ");
n = Convert.ToInt32(Console.ReadLine());

current = 2;

while (current <=n)
{
    Console.Write (current+ " ");
    current = current + 2;  
}

