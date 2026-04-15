Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());
bool podeVotar = (idade >= 16);
Console.WriteLine("Tem idade para votar? " + podeVotar);