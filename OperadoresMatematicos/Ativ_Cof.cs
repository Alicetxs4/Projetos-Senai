float cofrinho = 0;
float valor;

while (cofrinho < 50)
{
    Console.WriteLine("Coloque um valor no cofrinho: ");
    valor = float.Parse(Console.ReadLine());

    cofrinho += valor;

    Console.WriteLine("Total no cofrinho: " + cofrinho);
}
Console.WriteLine("Parabéns! Você atingiu 50 reais no cofrinho.");