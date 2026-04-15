using System;

public class EnunciadoEstrutura
{
    public static void Main()
    {
        double[,] estruturaPrat = new double[2,2];

        estruturaPrat[0,0] = 15;
        estruturaPrat[0,1] = 20;
        estruturaPrat[1,0] = 10;
        estruturaPrat[1,1] = 30;

        Console.WriteLine($"Relatório da Prateleira: ");

        double Prateleira = estruturaPrat[1,0] + estruturaPrat[1,1];

        Console.WriteLine($"Buchas = {estruturaPrat[1,0]}");
        Console.WriteLine($"Arruelas = {estruturaPrat[1,1]}");

        Console.WriteLine($"Total de Componentes na Prateleira Inferior: {Prateleira}");

    }
}