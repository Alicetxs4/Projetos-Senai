int categoria;
double valor, valorFinal;

Console.WriteLine("Informe o valor do produto: R$ ");
valor = double.Parse(Console.ReadLine());
Console.WriteLine("\nMENU DE CATEGORIAS: ");
Console.WriteLine("1 - Á vista");
Console.WriteLine("2 - Cartão");
Console.WriteLine("3 - Parcelado");
Console.Write("Escolha a categoria (1-3): ");
categoria = int.Parse(Console.ReadLine());

if (categoria == 1)
{
    valorFinal = valor * 0.90; 
}

else if (categoria == 3)
{
    valorFinal = valor * 0.95; 
}

else
{
    valorFinal = valor;
    Console.WriteLine("AVISO! Categoria sem desconto.");
}
Console.WriteLine($"Valor original: R$ {valor}");
Console.WriteLine($"Valor com desconto: R$ {valorFinal}");