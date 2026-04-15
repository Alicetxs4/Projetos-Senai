//Conversor de Reais para Centavos

Console.Write("Digite o valor em Reais: ");
double reais = double.Parse(Console.ReadLine());

double centavos = reais * 100;

Console.WriteLine("O valor de centavos é: " + centavos);