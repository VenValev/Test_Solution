Console.WriteLine("Hello, World!");
int a = 1;
int b = 1;
int c = a + b;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

while (a+b < 1000)
{
    a = b;
    b = c;
    c = a + b;
    Console.WriteLine(c);
}