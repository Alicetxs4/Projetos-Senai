using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main()
    {
        string[] nomes = new string[3];

        Console.WriteLine("Digite o 1° nome: ");
        nomes[0] = Console.ReadLine();

        Console.WriteLine("Digite o 2° nome: ");
        nomes[1] = Console.ReadLine();

        Console.WriteLine("Digite o 3° nome: ");
        nomes[2] = Console.ReadLine();

        Console.WriteLine($"Os nomes guardados foram: {nomes[0]}");
        Console.WriteLine($"Os nomes guardados foram: {nomes[1]}");
        Console.WriteLine($"Os nomes guardados foram: {nomes[2]}");
    }
}