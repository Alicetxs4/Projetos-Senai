//1. Entrada de Dados
using System.Data.Common;

Console.Write("Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

//Calculo da média
double media = (nota1 + nota2);

//Estrutura de Decisão
if (media >= 7)
{   
    Console.WriteLine("Aprovado! Média: " + media);
}
else
{
    Console.WriteLine("Reprovado! Média: " + media);
}
