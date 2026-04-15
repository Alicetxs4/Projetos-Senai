Console.Write("Digite a nota: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 90)
{
    Console.WriteLine("Desempenho Exelente!");
}

else if (nota >=70 && nota <= 90)
{
    Console.WriteLine("Desempenho Satisfatório.");
} 

else
{
    Console.WriteLine("Desempenho Ainda Não Atingido.");
}