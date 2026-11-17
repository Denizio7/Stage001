int soma(int n)
{
    //base case
    if(n == 50)
    {
        return 0;
    }
    //recursive case
    Console.WriteLine(n);
    return n + soma(n - 1);
}

Console.WriteLine(soma(52));