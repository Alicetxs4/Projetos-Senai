using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o nome para a posição {i}: ");
            nomes[i] = Console.ReadLine();
        }
        Console.WriteLine("Qual posição você quer consultar? ");
        int posicao = int.Parse(Console.ReadLine());
        //Retorna o valor do vetor
        Console.WriteLine($"Na posição {posicao} está o nome {nomes[posicao]}");
    }
}