using System;
class Program
{
    static void Main()
    {
        //1. Definição do Vetor - Guarda 5 Medidas
        double[] medidas = new double[5];

        //2. Entrada de Dados com FOR
        for (int i =0; i<5; i++)
        {
            Console.WriteLine($"Insira a medida da {i + 1}° peça (mm)");
            medidas[i] = double.Parse(Console.ReadLine());
        

        //Verifica o Valor Dentro do Vetor
        if(medidas[i] >=10.0 && medidas[i] <=10.5)
        {
            Console.WriteLine($"Peças{i}: {medidas[i]}mm -> [APROVADO]");
        }

        else
        {
            Console.WriteLine($"Peças{i}: {medidas[i]}mm -> [REPROVADO]");
        }
        }
    }
}