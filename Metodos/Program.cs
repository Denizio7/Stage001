int dobrar(int d) => d * 2;
Console.WriteLine(dobrar(5));

//Metodo sem parametro e sem retorno
void somar()
{
    System.Console.WriteLine("Digite dois numeros para somar");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int total = a + b;
    Console.WriteLine(total);
}
somar();
//Metodo com parametro e com retorno
int times(int x, int y)
{
    int total = x * y;
    return total;
}
int resl = times(5, 13);
Console.WriteLine(resl);

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int total1 = a + b;
// Console.WriteLine(total1);