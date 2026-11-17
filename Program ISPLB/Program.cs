
MostrarCabecalho();
Console.Write("Tabuada de : ");
MostarTabuada(int.Parse(Console.ReadLine()));
Console.WriteLine("\nDigite as 3 notas do aluno, para calcular a média e verificar se ele está aprovado ou reprovado.");
double n1 = LerNota();
double n2 = LerNota();
double n3 = LerNota();
double media = CalcularMedia(n1, n2, n3);
Console.WriteLine($"Situação: {EstaAprovado(media)}, com média: {media}");
MostrarCabecalho();

void MostrarCabecalho()
{
    Console.WriteLine("======================================================================");
    Console.WriteLine("                        ISPLB   -   INFORMATICA                       ");
    Console.WriteLine("======================================================================");
}
//Tabuada
void MostarTabuada( int n)
{
    for( int e = 0; e <= 10 ; e++)
    {
        Console.WriteLine($"{n} x {e} =  {n * e}");
    }
}
//Leitura de notas
double LerNota()
{
    Console.Write("Nota: ");
    double nota = double.Parse(Console.ReadLine());
    return nota;
}
//Calculo da media
double CalcularMedia(double n1, double n2, double n3)
{
    double media = (n1 + n2 + n3) / 3;
    return media;
}
//Verifica se o aluno esta aprovado
string EstaAprovado(double media)
{
    if(media >= 10)
    {
        return "Aprovado";
    }
    else
    {
        return "Reprovado";
    }
}


