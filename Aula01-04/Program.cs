using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[3];

        Console.Write("Digite o 1° número: ");
        numeros[0] = int.Parse(Console.ReadLine());

        Console.Write("Digite o 2° número: ");
        numeros[1] = int.Parse(Console.ReadLine());

        Console.Write("Digite o 3° número: ");
        numeros[2] = int.Parse(Console.ReadLine());

        Console.WriteLine("\nValores digitados: ");
        Console.WriteLine(numeros[0]);
        Console.WriteLine(numeros[1]);
        Console.WriteLine(numeros[2]);
    }
}