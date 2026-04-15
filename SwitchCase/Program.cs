double n1, n2, resultado;
string operacao;

Console.WriteLine("Digite o primeiro número: ");
n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha a operação (+, -, *, /): ");
operacao = Console.ReadLine();

switch (operacao)
{
    case "+":
    resultado = n1 + n2;
    Console.WriteLine("Resultado: " + resultado);
    break;

    case "-":
    resultado = n1 - n2;
    Console.WriteLine("Resultado: " + resultado);
    break;

    case "*":
    resultado = n1 * n2;
    Console.WriteLine("Resultado: " + resultado);
    break;

    case "/":
    resultado = n1 / n2;
    Console.WriteLine("Resultado: " + resultado);
    break;

    default:
    Console.WriteLine("Operação inválida.");
    break;
}
Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();