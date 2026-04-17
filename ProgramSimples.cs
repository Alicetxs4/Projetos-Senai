using System;

namespace CalculadoraSimples
{
    class program
    {
        
        static void Main (string[] args)
        {
            
            Console.WriteLine("---Calculadora SENAI---");

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Realiza a soma e exibe o resultado
            double soma = num1 + num2;
            Console.WriteLine($"O resultado da soma é: {soma}");
        }
    }
}