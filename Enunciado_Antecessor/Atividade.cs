Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());
bool podeEntrar = (idade >= 12);
Console.WriteLine("Tem idade para entrar? " + podeEntrar);

Console.Write("Digite o valor: ");
double preco = double.Parse(Console.ReadLine());
bool dinheiro = (preco >= 5.00);
Console.WriteLine("Ele tem o valor certo? " + dinheiro);
