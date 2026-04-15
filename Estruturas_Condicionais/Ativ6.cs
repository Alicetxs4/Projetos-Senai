Console.WriteLine("Digite seu peso:");
double peso = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura:");
double altura = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine("IMC: " + imc);

if (imc < 18.5)
{
    Console.WriteLine("Abaixo do peso");
}
else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine("Peso normal");
}
else
{
    Console.WriteLine("Sobrepeso");
}