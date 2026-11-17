int a = 1;
int b = 24;
int c = a + b;

//if ( (a + b) > 20)
bool meutest = c > 20;
if ( meutest ) // if is true
{
    Console.WriteLine($"Grather than 20: {a+b}");
}
else // if is false
{
    Console.WriteLine($"Lower than 20: {a+b}");
}

if( (a>b) || (c> 20))
{
    Console.WriteLine($"A: {a} > B: {b} ou C: {c}>20");
}
else
{
    Console.WriteLine("Como esta!");
}