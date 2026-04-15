using System;
using System.Diagnostics;

class Program
{
    
    static void Main()
    {
        //1. Criar o Vetor Para as 3 Temperaturas
        float[] clima = new float[3];
        Console.WriteLine("---CADASTRO DE TEMPERATURAS---");
        Console.Write("Digite a temperatura da cidade 1: ");
        clima[0] = float.Parse(Console.ReadLine());
        //Usamos o float.Parse para converter a string digitada em tipo float

        Console.Write("Digite a temperatura da cidade 2: ");
        clima[1] = float.Parse(Console.ReadLine());

        Console.Write("Digite a temperatura da cidade 3: ");
        clima[2] = float.Parse(Console.ReadLine());

        Console.WriteLine("---RELATÓRIO FINAL---");
        if(clima[0] < 20)
        {
            Console.WriteLine("Cidade 1: Clima Frio");
        }

        else if(clima[0] >= 20 && clima[0] <= 25)
        {
            Console.WriteLine("Cidade 1: Clima Agradavel");
        }

        else
        {
            Console.WriteLine("Cidade 1: Clima Quente");
        }

        Console.WriteLine("---RELATÓRIO FINAL---");
        if(clima[1] < 20)
        {
            Console.WriteLine("Cidade 2: Clima Frio");
        }

        else if(clima[1] >= 20 && clima[1] <= 25)
        {
            Console.WriteLine("Cidade 2: Clima Agradavel");
        }

        else
        {
            Console.WriteLine("Cidade 2: Clima Quente");
        }

        Console.WriteLine("---RELATÓRIO FINAL---");
        if(clima[2] < 20)
        {
            Console.WriteLine("Cidade 3: Clima Frio");
        }

        else if(clima[2] >= 20 && clima[2] <= 25)
        {
            Console.WriteLine("Cidade 3: Clima Agradavel");
        }

        else
        {
            Console.WriteLine("Cidade 3: Clima Quente");
        }
    }
}