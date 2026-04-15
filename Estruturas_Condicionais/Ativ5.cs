Console.Write("Qual o clima? ");
double clima = double.Parse(Console.ReadLine());

if (clima <= 15)
{
    Console.WriteLine("clima: " + clima);
    Console.WriteLine("Ativar Aquecedor.");
}
else if (clima >= 15 && clima <= 25)
{
    Console.WriteLine("clima: " + clima);
    Console.WriteLine("Temperatura ideal.");
}
else
{
    Console.WriteLine("clima: " + clima);
    Console.WriteLine("Ativar Resfriamento.");
}