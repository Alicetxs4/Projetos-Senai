using System;

public class MaiorVetor
{
    public static void Main()
    {
        int[] numeros = new int[5];
        int maior = 0;


        for (int i = 0; i < numeros.Length; i++) ;
        {
            Console.Write($"Digite o valor para a posição [{i}]: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if(i == 0)
            {
                maior = numeros[i];
            }

            else if(numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }
        Console.WriteLine($"Maior valor = {maior}");
    }
}