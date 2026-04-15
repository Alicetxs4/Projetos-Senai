//Declaração de variaveis
int x;
int r;
int cont;

//Estrutura de repetição
for (cont = 1; cont <= 4; cont++)
{
    //Entrada de dados
    x = int.Parse(Console.ReadLine());

    //Processamento
    r = x * 12;

    //Saída
    Console.WriteLine(r);
}