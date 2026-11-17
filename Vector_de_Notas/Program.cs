double[] numeros = new double[5];
double soma = 0;

for(int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Nota {i + 1}: ");
    numeros[i] = double.Parse(Console.ReadLine());
    soma = soma + numeros[i];
}

Console.WriteLine("Notas inseridas{}:");
foreach(double numero in numeros)
{
        Console.WriteLine(numero);
}

double media = soma / numeros.Length;
Console.WriteLine($"Média: {media}");
Console.WriteLine($"Soma: {soma}");
