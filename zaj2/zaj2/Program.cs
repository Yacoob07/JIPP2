// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int n1 = 10, n2 = 20;

if (n1 > n2)
{
    Console.WriteLine("n1 jest większe od n2");
}
else if(n1 < n2){
    Console.WriteLine("n2 jest większe od n1");
}
else Console.WriteLine("n1 jest równe n2");

for (int i=0; i<10; i++)
{
    Console.WriteLine("C#");
}

int a = 0;
while (a < 10)
{
    Console.WriteLine("C#");
        a++;
}

int n = 10;
for (int i=0; i<=n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " - Parzysta");
    }
    else
    {
        Console.WriteLine(i + " - Nieparzysta");
    }
}

n = 5; 
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* "); 
    }
    Console.WriteLine(); 
}