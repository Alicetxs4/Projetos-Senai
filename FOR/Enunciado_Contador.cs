string exercício;
int total;
int atual;

Console.Write("digite o nome do exercício: ");
exercício = Console.ReadLine();

Console.Write("Quantas repetições você irá fazer?");
total = int.Parse(Console.ReadLine());
for (atual =1; atual <=total; atual++)
{
    Console.WriteLine($"{exercício}: Repetição {atual} de {total}");
}
Console.WriteLine("Parabéns! Você terminou a série de exercício.");