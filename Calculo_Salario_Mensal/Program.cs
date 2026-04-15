Console.Write("Nome do funcionário: ");
string funcionario = Console.ReadLine();

Console.Write("Valor de hora: ");
double valorHora = double.Parse(Console.ReadLine());

Console.Write("Horas trabalhada: ");
double horas = double.Parse(Console.ReadLine());

double salarioTotal = valorHora * horas;

Console.WriteLine("O funcionário " + funcionario + " deve receber R$ " + salarioTotal);