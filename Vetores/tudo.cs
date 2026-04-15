using System;
class Program
{
    static void Main()
    {
        string[] nomes = new string[5];
        double[] notas = new double[5];

        for (int i =0; i <5; i++)
        {
            Console.WriteLine($"---CADASTRO DO {i + 1}° Aluno---");
            Console.Write("Nome: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Nota de {nomes[i]}: ");
            notas[i] = double.Parse(Console.ReadLine());

            Console.WriteLine(); //Linha em Branco Para Organizar
        }
        //Exibição Dos Dados
        Console.WriteLine("\n==== BOLETIM ESCOLAR ====");
        for (int i =0; i <5; i++)
        {
            Console.WriteLine($"ALuno: {nomes[i].PadRight(10)} | Nota: {notas[i]:F1}");
        }
    }
}