double a;
Console.WriteLine("Digite o número: ");
a = double.Parse(Console.ReadLine());

double b;
Console.WriteLine("Digite o número: ");
b = double.Parse(Console.ReadLine());

double c;
Console.WriteLine("Digite o número: ");
c = double.Parse(Console.ReadLine());

if (a == b && b == c)
{
    Console.WriteLine("Triângulo Equilátero");
}

else if (a == b || a == c || b == c)
{
    Console.WriteLine("Triângulo Isósceles");
}

else
{
    Console.WriteLine("Triângulo Escaleno"); 
}