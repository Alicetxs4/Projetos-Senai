int categoria;
double valor, valorFinal;

Console.WriteLine("Informe o valor do produto: R$ ");
valor = double.Parse(Console.ReadLine());
Console.WriteLine("\nMENU DE CATEGORIAS: ");
Console.WriteLine("1 - Alimentos");
Console.WriteLine("2 - Limpeza");
Console.WriteLine("3 - Eletrónicos");
Console.Write("Escolha a categoria (1-3): ");
categoria = int.Parse(Console.ReadLine());

switch (categoria)
{
    case 1:
    valorFinal = valor * 0.90; //10% dde desconto
    break;

    case 2:
    valorFinal = valor * 0.85; //15% de desconto
    break;

    case 3:
    valorFinal = valor * 0.80; //20% de desconto
    break; 

    default:
    valorFinal = valor;
    Console.WriteLine("AVISO! Categoria sem desconto.");
    break;
}
Console.WriteLine($"Valor original: R$ {valor}");
Console.WriteLine($"Valor com desconto: R$ {valorFinal}");