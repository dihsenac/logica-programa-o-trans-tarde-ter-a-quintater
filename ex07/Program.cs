// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Digite sua primeira nota: ");
float nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota: ");
float nota3 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine($"sua média é {media}");

if (media >= 7) ;
{
    Console.WriteLine("aprovado");
}

else if (media >= 4 && media <= 6.9) ;

{ Console.WriteLine("recuperaçao"); }

else (media <= 3.9);
{
    Console.WriteLine("reprovado");
}
