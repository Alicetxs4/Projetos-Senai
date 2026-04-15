string senha = "";

Console.WriteLine("Digite a senha: ");

while (senha != "Senai123")
{
    senha = Console.ReadLine();

    if (senha != "Senai123")
    {
        Console.WriteLine("Senha incorreta. Tente novamente.");
    }
}
Console.WriteLine("Acesso liberado!");