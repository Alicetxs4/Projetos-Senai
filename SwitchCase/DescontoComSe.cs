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

if (categoria == 1)
{
    valorFinal = valor * 0.90; //10% de desconto
}

else if (categoria == 2)
{
    valorFinal = valor * 0.85; //15% de desconto
}

else if (categoria == 3)
{
    valorFinal = valor * 0.80; //20% de desconto
}

else
{
    valorFinal = valor;
    Console.WriteLine("AVISO! Categoria sem desconto.");
}
Console.WriteLine($"Valor original: R$ {valor}");
Console.WriteLine($"Valor com desconto: R$ {valorFinal}");