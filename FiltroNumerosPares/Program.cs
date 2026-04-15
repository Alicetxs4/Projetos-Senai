using System; //Importa o namespace System, que contém classes fundamentais como a Console
namespace AulaLogicaSenai //Define um nome para o projeto
{
    class Program //Define uma classe chamada Program
    {
        //O método Main é o ponto de entrada (Entry Point) do programa
        //É por aqui que o Windows começa a ler e executar o seu software
        static void Main(string[] args)
        {
            //Declaração do Vetor (array) de 5 posições
            int[] numeros = new int[5];
            int contador = 0;

            Console.WriteLine("---ENTRADA DE DADOS (USANDO WHILE (ENQUANTO))---");
            //Estrutura de Repetição WHILE
            while(contador < numeros.Length)
            {
                
                Console.WriteLine($"Digite o {contador + 1}° número: ");

                //Convert.ToInt32 é necessário pois o Console.ReadLine retorna string
                numeros[contador] = Convert.ToInt32(Console.ReadLine());
                contador++;
            }
            //Estruturar uma Repetição
            for(int i=0; i < numeros.Length; i++)
            {
                //Se o Resto da Divisão por 2 for 0, o Número é par
                if(numeros[i] % 2 == 0)
                {
                    
                    Console.WriteLine($"O Número {numeros[i]} na posição {i+1} é PAR");
                }
            }
            Console.WriteLine("\nPressione Qualquer Tecla Para Encerrar");
            Console.ReadKey();
        }
    }
}