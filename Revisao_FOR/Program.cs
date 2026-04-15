//Tabuada
int numero;
int multiplicador;
int resultado;

Console.Write("Qual tabuada você deseja ver? ");
numero = int.Parse(Console.ReadLine());

for (multiplicador =1; multiplicador <=10; multiplicador++)
{
    resultado = numero * multiplicador;

    Console.WriteLine($"{numero} X {multiplicador} = {resultado}");
}
