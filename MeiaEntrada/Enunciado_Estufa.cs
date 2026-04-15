Console.WriteLine("Qual a temperatura: ");
double temperatura = double.Parse(Console.ReadLine());

if (temperatura >= 30)
{
    Console.WriteLine("Temperatura: " + temperatura);
    Console.WriteLine("Temperatura alta! ligando ventilador");
}

else
{
    Console.WriteLine("Temperatura: " + temperatura);
    Console.WriteLine("Temperatura normal. ventilador desligado");
}