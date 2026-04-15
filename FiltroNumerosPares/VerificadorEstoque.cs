using System;

class Program
{
    
    static void Main()
    {
        //Declaração de Variaveis
        int[] estoque = new int[5];

        //FOR Para Guardar os Pedidos
        for(int i=0; i<5; i++)
        {
             Console.WriteLine($"Digite a quantidade para a caixa {i}: ");
             estoque[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\n---RELATÓRIO---");
        for(int i=0; i<5; i++)
        {
            if(estoque[i] < 10)
            {
                Console.WriteLine($"Caixa {i}: Repor");
            }

            else
            {
                Console.WriteLine($"Caixa {i}: OK");
            }
        }
    }
}