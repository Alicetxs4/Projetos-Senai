Console.Write("Qual o seu saldo: ");
double preco = double.Parse(Console.ReadLine());

Console.Write("Qual valor da corrida: ");
int corrida = int.Parse(Console.ReadLine());

if (corrida >= preco)
{
    double valor = preco;
    Console.WriteLine("saldo: " + valor);
    Console.WriteLine("corrida recusada!");
}

else
{
    double valor = preco;
    Console.WriteLine("saldo: " + valor);
    Console.WriteLine("corrida aceita!");
}