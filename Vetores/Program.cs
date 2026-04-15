using System;

class Program
{
    static void Main()
    {
        string[] aluno = new string[3];

        //Colocando dados nas gavetas (indices)
        aluno[0] = "Ana";
        aluno[1] = "Bruno";
        aluno[2] = "Carlos";

        //Exibir apenas um aluno especifico usando indice
        Console.WriteLine("O primeiro aluno da lista é: " + aluno[0]);
    }
}