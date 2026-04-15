int codigo;
double preco;
string procedencia;

Console.WriteLine("-----SISTEMA DE CONSULTA DE PROCEDENCIA-----");
Console.Write("Digite o preço do produto: R$ ");
preco = double.Parse(Console.ReadLine());

Console.WriteLine("CÓDIGOS DE ORIGEM: ");
Console.Write("1-Sul | 2-Norte | 3-Leste | 4-Oeste | 5 ou 6-Nordeste");
Console.Write("7, 8 ou 9-Sudeste | 10-Centro-Oeste | 11-Noroeste");
Console.Write("Digiteno código de origem: ");
codigo = int.Parse(Console.ReadLine());

switch (codigo)
{
    case 1: 
    procedencia = "Sul";
    break;

    case 2:
    procedencia = "Norte";
    break;

    case 3: 
    procedencia = "Leste";
    break;

    case 4:
    procedencia = "Oeste";
    break;

    case 5:
    case 6:
    procedencia = "Nordeste";
    break;

    case 7:
    case 8:
    case 9:
    procedencia = "Sudeste";
    break;

    case 10:
    procedencia = "Centro-Oeste";
    break;

    case 11:
    procedencia = "Noroeste";
    break;

    default:
    procedencia = "Importado / Código Inválido";
    break;
}
Console.WriteLine($"Preço do Produto: R$ {preco}");
Console.WriteLine($"Código de Origem do Produto: {procedencia} ");