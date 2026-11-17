//using System.Linq.Expressions;
using Humanizer;
Console.WriteLine("Ola, Tu!");

string firstf = "John";
string secondf = "     Maria  ";

string bestf = $"Meus amigos sao {firstf.Trim()} e {secondf.Trim()}";
Console.WriteLine(bestf);
Console.WriteLine(bestf.Replace("John" , "Michael"));
Console.WriteLine(bestf);
bestf = bestf.Replace("John" , "Michael");
Console.WriteLine(bestf);
Console.WriteLine(bestf.Length);
Console.WriteLine(bestf);