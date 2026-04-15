Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Acesso Autorizado: Usuário maior de idade.");
}

else
{
    Console.WriteLine("Acesso Negado: Usuário menor de idade.");
}