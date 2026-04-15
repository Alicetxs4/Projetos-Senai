using System;

public class SomaVetor
{
    public static void Main()
    {
        int[] numeros = new int [5];
        int soma = 0;

        for(int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Digite o valor para a posição [{i}]: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        soma += numeros[i];

        Console.WriteLine($"Soma Total = {soma}");
    }
}