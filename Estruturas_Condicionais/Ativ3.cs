double desconto;

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite seu tempo de empresa: ");
double tempo = double.Parse(Console.ReadLine());

if (tempo >= 10)
{
    desconto = tempo * 0.80;
}

else if (tempo <=10 || tempo >=5)
{
    desconto = tempo * 0.90;
}

else
{
    desconto = tempo * 0.95;
}
Console.WriteLine($"O funcionário {nome} receberá o bonús de: R${desconto}");