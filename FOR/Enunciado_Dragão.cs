int vidaDragao = 100;
int danoGerado;
int escolha;
int turno;

Console.WriteLine("Um dragão apareceu! Você tem 5 turnos para derrotá-lo.");

for ( turno =1; turno<=5; turno++)
{
    Console.WriteLine("\n---------------------------------");
    Console.WriteLine($"TURNO {turno} | VIDA DO DRAGÃO: {vidaDragao} HP");
    Console.WriteLine("[1] Ataque com espada");
    Console.WriteLine("[2] Lança Magia");
    Console.WriteLine("[3] Cura");

    escolha = int.Parse(Console.ReadLine());

    if (escolha == 1)
    {
        danoGerado = 20;
        vidaDragao = vidaDragao - danoGerado;
        Console.WriteLine($"Você golpeou o Dragão {danoGerado} de dano");
    }

    else if (escolha == 2)
    {
        danoGerado = 35;
        vidaDragao = vidaDragao - danoGerado;
        Console.WriteLine($"Magia poderosa! Cansou {danoGerado} de dano");
    }

    else
    {
        Console.WriteLine("Você se curou, mas o Dragão riu de você!");
    }

    if (vidaDragao <=0)
    {
        Console.WriteLine("O Dragão morreu!");
        break;
    }
}
if (vidaDragao > 0)
{
    Console.WriteLine("O tempo acabou. O Dragão te derrotou!");
}

