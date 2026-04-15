double valorReal, valorConvertido = 0;
int opcao;

Console.WriteLine("Digite o valor em Reais (R$): ");
valorReal = double.Parse(Console.ReadLine());

Console.WriteLine("1-Dolar (USD)");
Console.WriteLine("2-Euro (EUR)");
Console.WriteLine("3-Peso Argentino (ARS)");
Console.WriteLine("4-Libra (GBR)");
Console.Write("Escolha a moeda para conversão: ");

opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
    valorConvertido = valorReal / 5.00;
    Console.WriteLine($"Valor Convertido {valorConvertido:F2}");
    break;

    case 2:
     valorConvertido = valorReal / 5.50;
    Console.WriteLine($"Valor Convertido {valorConvertido:F2}");
    break;

    case 3:
     valorConvertido = valorReal / 160.00;
    Console.WriteLine($"Valor Convertido {valorConvertido:F2}");
    break;

    case 4:
     valorConvertido = valorReal / 6.50;
    Console.WriteLine($"Valor Convertido {valorConvertido:F2}");
    break;

    default: 
    Console.WriteLine("[ERRO]: Opção Inválida.");
    break;
}