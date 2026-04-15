//Declaração de variaveis
int porcentagem;
int cont;

Console.WriteLine("Iniciando a instalação...");
//O laço vai de 1 a 10
for (cont = 1; cont <=10; cont++)

{
    porcentagem = cont * 10;
    Console.WriteLine($"Progresso {porcentagem}%");
}
Console.WriteLine("\n Sistema instalado com sucesso!");