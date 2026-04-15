double precoDoProduto;
double contaTotal = 0;
int codigoDaCategoria;
int produtoAtual;

Console.WriteLine("===BEM-VINDO A LAMCHONETE ESCOLA SENAI BARRA FUNDA===");
for (produtoAtual = 1; produtoAtual <=5; produtoAtual++)
{
    Console.WriteLine("PASSANDO O PRODUTO NÚMERO: " + produtoAtual);

    Console.WriteLine("Qual o preço deste produto? R$ ");
    precoDoProduto = double.Parse(Console.ReadLine());

    Console.WriteLine("Categoria: 1-Limpeza | 2-Alimento | 3-Eletronico");
    Console.Write("Qual o código da categoria? ");
    codigoDaCategoria = int.Parse(Console.ReadLine());
    switch (codigoDaCategoria)
    {
        case 1:
        case 2:
        contaTotal = contaTotal + precoDoProduto;
        Console.WriteLine("Produto comum somado.");
        break;

        case 3:
        contaTotal = contaTotal + (precoDoProduto *1.10);
        Console.WriteLine("Eletronico somado com taxa de 10%");
        break;

        default:
        Console.WriteLine("Código errado!");
        break;
    }
}
Console.WriteLine("VALOR TOTAL A PAGAR: R$ " +contaTotal);