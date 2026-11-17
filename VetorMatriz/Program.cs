using System.Globalization;
using System.Reflection.Metadata;

int[] num = new int[5];
for(int i = 0 ; i < num.Length; i++)
{
    Console.Write($"Intem {i +1}: ");
    num[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\n");
for(int i = 0; i < num.Length; i++)
{
    Console.WriteLine($"Vector {i}: {num[i]}");
}