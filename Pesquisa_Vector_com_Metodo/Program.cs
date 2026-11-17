int[] number = new int[5];

for(int i = 0; i < number.Length; i++)
{
    Console.Write($"N{i + 1}.:");
    number[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Pesquisar por: ");
int value = int.Parse(Console.ReadLine());
int position = Pesquisar(number, value);


if (position == -1)
{
    Console.WriteLine("Valor não existe.");
}else{
    Console.WriteLine($"Valor achado na posição: {position}");
    }


static int Pesquisar(int[] v, int value)
{
    for(int i = 0; i < v.Length; i++)
    {
        if(v[i] == value)
        {
            return i;
        }
    }
    return -1;
}