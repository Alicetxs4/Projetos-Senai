Console.Write("Qual a cor do semáforo?: ");
string cor = Console.ReadLine();

if (cor == "verde")
{
    Console.WriteLine("Cor: " + cor);
    Console.WriteLine("Siga em frente!");
}

else if (cor == "amarelo")
{
    Console.WriteLine("Cor: " + cor);
    Console.WriteLine("Atenção, reduza a velocidade!");
}            

else if (cor == "vermelho")
{
    Console.WriteLine("Cor: " + cor);
    Console.WriteLine("Pare, aguarde o sinal verde");
}

else
{
    Console.WriteLine("Cor inválida!");
}