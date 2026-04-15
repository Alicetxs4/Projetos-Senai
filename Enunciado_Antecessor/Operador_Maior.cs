Console.Write("Digite o preço do produto: ");
double preco = double.Parse(Console.ReadLine());
bool caro = (preco > 50.0);
Console.WriteLine("O Produto custa mais de R$50,00" + caro);