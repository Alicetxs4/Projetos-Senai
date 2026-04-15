int tabuada;
int resultado;
int multiplicador;

Console.Write("Digite o número da tabuada: ");
tabuada = int.Parse(Console.ReadLine());
for (multiplicador =1; multiplicador <=10; multiplicador++)
{
    resultado = tabuada*multiplicador;
    Console.WriteLine($"{tabuada} X {multiplicador} = {resultado}");
}